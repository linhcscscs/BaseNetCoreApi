using BaseNetCoreApi.DomainService.Interface;
using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.Repository;
using BaseNetCoreApi.Services.Interface;
using BaseNetCoreApi.Values;
using Microsoft.AspNetCore.Http.Extensions;

namespace BaseNetCoreApi.DomainService
{
    public class WorkContextService : IWorkContextService
    {
        #region Contructor
        private IServiceProvider _serviceProvider;
        private IHttpContextAccessor _httpContextAccessor;
        public WorkContextService(
            IServiceProvider serviceProvider,
            IHttpContextAccessor httpContextAccessor)
        {
            _serviceProvider = serviceProvider;
            _httpContextAccessor = httpContextAccessor;
        }
        #endregion
        private NguoiDung? _nguoiDung = null;
        private List<GroupUserMenu> _permissons;
        private int? ma_nam_hoc = null;
        private Guid? _sessionId = null;
        private decimal? _nguoiDungId = null;
        private INguoiDungRepository _nguoiDungRepository;
        private IPermissionService _permissionService;
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
                if (_nguoiDung == null && _nguoiDungId != null)
                {
                    if (_nguoiDungRepository == null)
                    {
                        _nguoiDungRepository = _serviceProvider.GetService<INguoiDungRepository>()!;
                    }
                    _nguoiDung = _nguoiDungRepository.GetById(NguoiDungId) ?? new NguoiDung();
                }
                return _nguoiDung!;
            }
        }
        public string MA_TINH
        {
            get
            {
                if (!string.IsNullOrEmpty(_httpContextAccessor.getCookie(UserCookieKey.MA_TINH)))
                {
                    return _httpContextAccessor.getCookie(UserCookieKey.MA_TINH)!;
                }
                else
                {
                    _httpContextAccessor.setCookie(UserCookieKey.MA_TINH, NguoiDung?.MaTinh ?? "");
                    return NguoiDung?.MaTinh ?? "";
                }
            }
        }
        public string MA_HUYEN
        {
            get
            {
                if (!string.IsNullOrEmpty(_httpContextAccessor.getCookie(UserCookieKey.MA_HUYEN)))
                {
                    return _httpContextAccessor.getCookie(UserCookieKey.MA_HUYEN)!;
                }
                else
                {
                    _httpContextAccessor.setCookie(UserCookieKey.MA_HUYEN, NguoiDung?.MaHuyen ?? "");
                    return NguoiDung?.MaHuyen ?? "";
                }
            }
        }
        public string MA_XA
        {
            get
            {
                if (!string.IsNullOrEmpty(_httpContextAccessor.getCookie(UserCookieKey.MA_XA)))
                {
                    return _httpContextAccessor.getCookie(UserCookieKey.MA_XA)!;
                }
                else
                {
                    _httpContextAccessor.setCookie(UserCookieKey.MA_XA, NguoiDung?.MaXa ?? "");
                    return NguoiDung?.MaHuyen ?? "";
                }
            }
        }
        public bool IsRoot
        {
            get
            {
                return NguoiDung.IsRoot == 1 || NguoiDung.IsRootSys == 1;
            }
        }
        public bool IsRootSys
        {
            get
            {
                return NguoiDung.IsRootSys == 1;
            }
        }
        public bool IsAuthenticated
        {
            get
            {
                if (_nguoiDungId != null || _sessionId != null) return true;
                return false;
            }
        }
        public string FullRequestURL
        {
            get
            {
                return _httpContextAccessor?.HttpContext?.Request.GetDisplayUrl() ?? "";
            }
        }
        public string RequestPath
        {
            get
            {
                return _httpContextAccessor?
                  .HttpContext?.Request?.Path ?? "";
            }
        }
        public List<GroupUserMenu> Permissons
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
                    if (_nguoiDungId == null)
                    {
                        _permissons = new List<GroupUserMenu>();
                    }
                    var permissionPath = RequestPath.Substring(0, RequestPath.LastIndexOf("/"));
                    _permissons = _permissionService.GetGroupUserMenuByNguoiDungByPath(_nguoiDungId!.Value, permissionPath);
                }
                return _permissons;
            }
        }
        public IHttpContextAccessor HttpContextAccessor => _httpContextAccessor;
    }
}
