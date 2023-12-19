using BaseNetCoreApi.DomainService;
using BaseNetCoreApi.DomainService.Interface;
using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.ContextProvider.Interface;
using BaseNetCoreApi.Infrastructure.Models.MongoDb;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Models.Collection.Interface;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.Repository;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Services.Interface;
using BaseNetCoreApi.Values;
using EFCore.BulkExtensions;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using static BaseNetCoreApi.Models.ViewModel.AuthResponse;

namespace BaseNetCoreApi.Services
{
    public class AuthenticateService : IAuthenticateService
    {
        private INguoiDungService _nguoiDungService;
        private IPermissionService _permissionService;
        private IQiCache _qiCache;
        private IPhoCapGDContextProvider _contextProvider;
        private IWorkContextService _workContextService;
        private IHttpContextAccessor _httpContextAccessor;
        private IUnitOfWork _unitOfWork;
        private IRefreshTokenRepository _refreshTokenRepository;
        private ILogSYSCollection _logSYSCollection;
        public AuthenticateService(
            INguoiDungService nguoiDungService,
            IQiCache qiCache,
            IPermissionService permissionService,
            IPhoCapGDContextProvider contextProvider,
            IWorkContextService workContextService,
            IHttpContextAccessor httpContextAccessor,
            IUnitOfWork unitOfWork,
            IRefreshTokenRepository refreshTokenRepository,
            ILogSYSCollection logSYSCollection)
        {
            _nguoiDungService = nguoiDungService;
            _qiCache = qiCache;
            _permissionService = permissionService;
            _contextProvider = contextProvider;
            _workContextService = workContextService;
            _httpContextAccessor = httpContextAccessor;
            _unitOfWork = unitOfWork;
            _refreshTokenRepository = refreshTokenRepository;
            _logSYSCollection = logSYSCollection;
        }
        private string GenerateJwtToken(NguoiDung nguoiDung)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(JWTSettings.Secret);
            var claims = new ClaimsIdentity(
                new[] {
                    new Claim(UserClaimKey.NguoiDungId, nguoiDung.Id.ToString()),
                });

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = JWTSettings.ValidIssuer,
                Audience = JWTSettings.ValidAudience,
                Subject = claims,
                Expires = DateTime.UtcNow.AddMinutes(JWTSettings.TokenValidityInMinutes),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
        private string GenerateRefreshToken(NguoiDung nguoiDung)
        {
            var randomNumber = new byte[64];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            var refreshToken = Convert.ToBase64String(randomNumber);
            using (var context = _contextProvider.GetContext(_workContextService.MA_NAM_HOC, true))
            {
                var rftModel = new RefreshToken()
                {
                    ExpDate = DateTime.Now.AddDays(JWTSettings.RefreshTokenValidityInDays),
                    Active = true,
                    NguoiDungId = nguoiDung.Id,
                    Token = refreshToken,
                };
                _refreshTokenRepository.InsertOrUpdate(rftModel);
                context.SaveChanges();
            }

            return refreshToken;
        }
        private AuthResponse GetAuth(NguoiDung nguoiDung, string ma_tinh, string ma_huyen, string ma_xa)
        {
            var authResponse = new AuthResponse();

            authResponse.NguoiDungId = nguoiDung.Id;

            // Get JWT token
            var accessToken = GenerateJwtToken(nguoiDung);
            authResponse.AccessToken = accessToken;

            // Rf Token
            var refreshToken = GenerateRefreshToken(nguoiDung);
            authResponse.RefreshToken = refreshToken;

            // IsRoot
            authResponse.IsRoot = nguoiDung.IsRoot == 1;
            authResponse.IsRootSys = nguoiDung.IsRootSys == 1;

            // Permission
            authResponse.Permissions = _permissionService.GetGroupUserMenuByNguoiDung(nguoiDung.Id).Select(s => new GroupUserPermission()
            {
                URL = s.Menu.Link,
                MenuName = s.Menu.MenuName,
                MenuLevel = s.Menu.LevelItem,
                MenuId = s.Menu.MenuId,
                IsAdd = s.IsAdd == 1,
                IsAuth = s.IsAuth == 1,
                IsDelete = s.IsDelete == 1,
                IsEdit = s.IsEdit == 1,
                IsUpload = s.IsUpload == 1,
                IsView = s.IsView == 1,
                MenuNameEg = s.Menu.MenuNameEg
            }).GroupBy(grp => grp.MenuId).Select(s => new GroupUserPermission()
            {
                URL = s.FirstOrDefault()?.URL,
                MenuName = s.FirstOrDefault()?.MenuName,
                MenuId = s.FirstOrDefault()!.MenuId,
                MenuLevel = s.FirstOrDefault()?.MenuLevel,
                MenuNameEg = s.FirstOrDefault()?.MenuNameEg,
                IsAdd = s.Any(a => a.IsAdd),
                IsAuth = s.Any(a => a.IsAuth),
                IsDelete = s.Any(a => a.IsDelete),
                IsEdit = s.Any(a => a.IsEdit),
                IsUpload = s.Any(a => a.IsUpload),
                IsView = s.Any(a => a.IsView)
            }).ToList();

            // Cookie 
            _httpContextAccessor.setCookie(UserCookieKey.MA_HUYEN, ma_tinh);
            _httpContextAccessor.setCookie(UserCookieKey.MA_TINH, ma_huyen);
            _httpContextAccessor.setCookie(UserCookieKey.MA_XA, ma_xa);

            return authResponse;
        }
        public void ForceReLogin(List<decimal> nguoiDungIds)
        {
            // Refresh Token
            using (var context = _contextProvider.GetContext(_workContextService.MA_NAM_HOC, true))
            {
                var rmvLst = context.RefreshTokens.Where(q => nguoiDungIds.Contains(q.NguoiDungId)).ToArray();
                context.BulkDelete<RefreshToken>(rmvLst);
                context.SaveChanges();
            }
        }
        public ReturnCode Login(LoginRequest model, out AuthResponse authResponse)
        {
            var ret = new ReturnCode();
            authResponse = new AuthResponse();
            var nguoiDung = _nguoiDungService.GetByUsernameAndPassword(model);
            if (nguoiDung == null)
            {
                ret = new ReturnCode(EReturnCode.WrongUsernameOrPassword);
                return ret;
            }
            authResponse = GetAuth(nguoiDung, model.ma_tinh, model.ma_huyen, model.ma_xa);
            var httpContextAccessor = _workContextService.HttpContextAccessor;
            _logSYSCollection.Save(new LogSYSModel()
            {
                _id = MongoDB.Bson.ObjectId.GenerateNewId(),
                MA_NAM_HOC = _workContextService.MA_NAM_HOC,
                MA_TINH = model.ma_tinh,
                MA_HUYEN = model.ma_huyen,
                MA_XA = model.ma_xa,
                NGAY_TAO = DateTime.Now,
                HANH_DONG = LogType.LOG_IN,
                TEN_BANG = "",
                GHI_CHU = "Đăng nhập",
                NGUOI_TAO = model.Username,
                IP = httpContextAccessor.GetIPAddress(),
                URL = httpContextAccessor.GetURL(),
                USER_AGENT = httpContextAccessor.GetUserAgent()
            });
            return ret;
        }
        public ReturnCode RefreshAccessToken(RefreshAccessTokenRequest model, out AuthResponse authResponse)
        {
            var ret = new ReturnCode();
            authResponse = new AuthResponse();
            using (var context = _contextProvider.GetContext(_workContextService.MA_NAM_HOC, true))
            {
                var rftModel = context.RefreshTokens.FirstOrDefault(q => q.NguoiDungId == model.NguoiDungId && q.Token == model.RefreshToken && q.ExpDate >= DateTime.Now);
                if (rftModel == null)
                {
                    ret = new ReturnCode(EReturnCode.TokenInvalid);
                    return ret;
                }
                if (rftModel.Active == false)
                {
                    ForceReLogin(new List<decimal>() { _workContextService.NguoiDungId });
                    ret = new ReturnCode(EReturnCode.TokenInvalid);
                    return ret;
                }

                var nguoiDung = context.NguoiDungs.FirstOrDefault(q => q.Id == model.NguoiDungId);
                if (nguoiDung == null)
                {
                    ret = new ReturnCode(EReturnCode.TokenInvalid);
                    return ret;
                }

                // Refresh Token
                rftModel.Active = false;
                context.RefreshTokens.Update(rftModel);
                context.SaveChanges();

                authResponse = GetAuth(nguoiDung, model.ma_tinh, model.ma_huyen, model.ma_xa);
            }
            return ret;
        }
        public void Logout(LogoutRequest model)
        {
            using (var context = _contextProvider.GetContext(_workContextService.MA_NAM_HOC, true))
            {
                var rftModel = context.RefreshTokens.FirstOrDefault(q => q.NguoiDungId == _workContextService.NguoiDungId && q.Token == model.RefreshToken);
                if (rftModel != null)
                {
                    rftModel.Active = false;
                    context.RefreshTokens.Update(rftModel);
                    context.SaveChanges();
                }
            }
        }
        public void ClearRefreshToken()
        {
            using (var context = _contextProvider.GetContext(_workContextService.MA_NAM_HOC, true))
            {
                var lstRft = context.RefreshTokens.Where(q => q.ExpDate <= DateTime.Now).ToList();
                context.BulkDelete(lstRft);
                context.SaveChanges();
            }
        }
    }
}
