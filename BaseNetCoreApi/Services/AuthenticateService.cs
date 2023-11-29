using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.ContextProvider;
using BaseNetCoreApi.Infrastructure.Models.BO_GIAO_DUCEntities;
using BaseNetCoreApi.Models.BO_GIAO_DUCEntities;
using BaseNetCoreApi.Models.Entities;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Service;
using BaseNetCoreApi.Values;
using EFCore.BulkExtensions;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace BaseNetCoreApi.Services
{
    public interface IAuthenticateService
    {
        ReturnCode Login(LoginRequest model, out AuthResponse authResponse);
        ReturnCode RefreshAccessToken(RefreshAccessTokenRequest model, out AuthResponse authResponse);
        void Logout(LogoutRequest model);
        NguoiDungAuthEntity? GetAuthEntityBySessionId(Guid sessionId, decimal nguoiDungId);
        void CommonBackgroundTask();
    }
    public class AuthenticateService : IAuthenticateService
    {
        private INguoiDungService _nguoiDungService;
        private IPermissionService _permissionService;
        private IQiCache _qiCache;
        private IContextProvider<BO_GIAO_DUCEntities> _contextProvider;
        private IWorkContextService _workContextService;
        public AuthenticateService(INguoiDungService nguoiDungService, IQiCache qiCache, IPermissionService permissionService, IContextProvider<BO_GIAO_DUCEntities> contextProvider, IWorkContextService workContextService)
        {
            _nguoiDungService = nguoiDungService;
            _qiCache = qiCache;
            _permissionService = permissionService;
            _contextProvider = contextProvider;
            _workContextService = workContextService;
        }
        private string GenerateJwtToken(NguoiDung nguoiDung, Guid sessionId)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(JWTSettings.Secret);
            var claims = new ClaimsIdentity(
                new[] {
                    new Claim(UserClaimKey.NguoiDungId, nguoiDung.Id.ToString()),
                });

            if (ConfigurationHelper.IsSessionAuth)
            {
                claims.AddClaim(new Claim(UserClaimKey.SessionId, sessionId.ToString()));
            }

            var lstQuyen = _permissionService.GetPermissonGroupByUserAndBranch(nguoiDung).Select(s => s.Code).ToList();
            claims.AddClaim(new Claim(UserClaimKey.Permissions, string.Join(",", lstQuyen)));

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
                context.RefreshTokens.Add(rftModel);
                context.SaveChanges();
            }

            return refreshToken;
        }
        private AuthResponse GetAuth(NguoiDung nguoiDung)
        {
            var authResponse = new AuthResponse();
            var sessionData = new NguoiDungAuthEntity()
            {
                NguoiDungId = nguoiDung.Id,
            };


            // Lưu vào cache phiên hoạt động
            var sessionId = Guid.NewGuid();
            if (ConfigurationHelper.IsSessionAuth)
            {
                _qiCache.Set(
                 key: _qiCache.BuildCachedKey("Auth", nguoiDung.Id, sessionId),
                 data: sessionData,
                 cacheTime: JWTSettings.TokenValidityInMinutes
                 );
            }

            // Get JWT token
            var accessToken = GenerateJwtToken(nguoiDung, sessionId);
            authResponse.AccessToken = accessToken;

            // Rf Token
            var refreshToken = GenerateRefreshToken(nguoiDung);
            authResponse.RefreshToken = refreshToken;


            return authResponse;
        }

        public NguoiDungAuthEntity? GetAuthEntityBySessionId(Guid sessionId, decimal nguoiDungId)
        {
            try
            {
                return _qiCache.Get<NguoiDungAuthEntity>(_qiCache.BuildCachedKey("Auth", nguoiDungId, sessionId));
            }
            catch
            {
                return null;
            }
        }

        public void ForceReLogin(List<decimal> nguoiDungIds)
        {
            // Cache
            if (ConfigurationHelper.IsSessionAuth)
            {
                nguoiDungIds.ForEach(nguoiDungId =>
                {
                    _qiCache.RemoveByFirstName(_qiCache.BuildCachedKey("Auth", nguoiDungId));
                });
            }

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
            authResponse = GetAuth(nguoiDung);

            return ret;
        }
        public ReturnCode RefreshAccessToken(RefreshAccessTokenRequest model, out AuthResponse authResponse)
        {
            var ret = new ReturnCode();
            authResponse = new AuthResponse();
            using (var context = _contextProvider.GetContext(_workContextService.MA_NAM_HOC, true))
            {
                var rftModel = context.RefreshTokens.FirstOrDefault(q => q.NguoiDungId == _workContextService.NguoiDungId && q.Token == model.RefreshToken && q.ExpDate >= DateTime.Now);
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

                var nguoiDung = context.NguoiDungs.FirstOrDefault(q => q.Id == _workContextService.NguoiDungId);
                if (nguoiDung == null)
                {
                    ret = new ReturnCode(EReturnCode.TokenInvalid);
                    return ret;
                }

                // Refresh Token
                rftModel.Active = false;
                context.RefreshTokens.Update(rftModel);
                context.SaveChanges();
                authResponse = GetAuth(nguoiDung);
            }
            return ret;
        }
        public void Logout(LogoutRequest model)
        {
            if (ConfigurationHelper.IsSessionAuth)
            {
                _qiCache.Remove(_qiCache.BuildCachedKey("Auth", _workContextService.NguoiDungId, _workContextService.SessionId));
            }
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
        public void CommonBackgroundTask()
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
