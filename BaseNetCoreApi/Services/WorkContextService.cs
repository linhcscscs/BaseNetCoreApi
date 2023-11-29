using BaseNetCoreApi.DomainService;
using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.ContextProvider;
using BaseNetCoreApi.Infrastructure.Models.BO_GIAO_DUCEntities;
using BaseNetCoreApi.Models.BO_GIAO_DUCEntities;
using BaseNetCoreApi.Models.Entities;
using BaseNetCoreApi.Services;
using BaseNetCoreApi.Values;

namespace BaseNetCoreApi.Service
{
    public interface IWorkContextService
    {
        public decimal NguoiDungId { get; set; }
        public int MA_NAM_HOC { get; }
        public NguoiDung NguoiDung { get; }
        public List<PermissonEntity> Permissons { get; }
        public bool IsRoot { get; }
        public Guid SessionId { get; set; }
        public bool IsAuthenticated { get; }
    }
    public class WorkContextService : IWorkContextService
    {
        #region Contructor
        private IServiceProvider _serviceProvider;
        private IHttpContextAccessor _httpContextAccessor;
        public WorkContextService(IServiceProvider serviceProvider, IHttpContextAccessor httpContextAccessor)
        {
            _serviceProvider = serviceProvider;
            _httpContextAccessor = httpContextAccessor;
        }
        #endregion
        private NguoiDung? _nguoiDung = null;
        private List<PermissonEntity> _permissons;
        private int? ma_nam_hoc = null;
        private Guid? _sessionId = null;
        private decimal? _nguoiDungId = null;
        private INguoiDungService _nguoiDungService;
        private IPermissionService _permissionService;
        private IAuthenticateService _authenticateService;
        public decimal NguoiDungId
        {
            get
            {
                return _nguoiDungId ?? 0;
            }
            set
            {
                _nguoiDungId = value;
            }
        }
        public Guid SessionId
        {
            get
            {
                return _sessionId ?? Guid.Empty;
            }
            set
            {
                _sessionId = value;
            }
        }
        public int MA_NAM_HOC
        {
            get
            {
                if (ma_nam_hoc == null)
                {
                    ma_nam_hoc = ConfigurationHelper.NamHoc;
                }
                return ma_nam_hoc.Value;
            }
        }
        public NguoiDung NguoiDung
        {
            get
            {
                if (_nguoiDung == null)
                {
                    if (_nguoiDungService == null)
                    {
                        _nguoiDungService = _serviceProvider.GetService<INguoiDungService>()!;
                    }
                    _nguoiDung = _nguoiDungService.GetByNguoiDungId(NguoiDungId) ?? new NguoiDung();
                }
                return _nguoiDung;
            }
        }
        public string MA_SO_GD
        {
            get
            {
                return NguoiDung?.MaSoGd ?? "";
            }
        }
        public string MA_TRUONG
        {
            get
            {
                return NguoiDung?.MaTruong ?? "";
            }
        }
        public bool IsRoot
        {
            get
            {
                return NguoiDung.IsRoot == 1;
            }
        }
        public bool IsAuthenticated
        {
            get
            {
                if (ConfigurationHelper.IsSessionAuth)
                {
                    if (_nguoiDungId == null || _sessionId == null) return false;
                    if (_authenticateService == null)
                    {
                        _authenticateService = _serviceProvider
                            .GetService<IAuthenticateService>()!;
                    }
                    return _authenticateService
                        .GetAuthEntityBySessionId(SessionId, NguoiDungId)?.NguoiDungId == NguoiDungId;
                }
                else
                {
                    if (_nguoiDungId != null || _sessionId != null) return true;
                }
                return false;
            }
        }
        public List<PermissonEntity> Permissons
        {
            get
            {
                if (_permissons == null)
                {
                    if (_permissionService == null)
                    {
                        _permissionService = _serviceProvider
                            .GetService<IPermissionService>()!;
                    }
                    if (ConfigurationHelper.IsSessionAuth)
                    {
                        if (!IsAuthenticated)
                        {
                            _permissons = new List<PermissonEntity>();
                        }
                        else
                        {
                            _permissons = _permissionService
                                .GetPermissonGroupByUserAndBranch(NguoiDung);
                        }
                    }
                    else
                    {
                        var slstPermission = AuthHelper.GetByClaim(_httpContextAccessor?.HttpContext?.User ?? new System.Security.Claims.ClaimsPrincipal(), UserClaimKey.Permissions);
                        var lstPermission = slstPermission.Split(',').ToList();
                        _permissons = _permissionService.GetPermissonEntities()
                            .Where(s => lstPermission.Contains(s.Code)).ToList();
                    }
                }
                return _permissons;
            }
        }
    }
}
