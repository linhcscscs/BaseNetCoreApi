using BaseNetCoreApi.DomainService;
using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.ContextProvider;
using BaseNetCoreApi.Infrastructure.Models.BO_GIAO_DUCEntities;
using BaseNetCoreApi.Models.BO_GIAO_DUCEntities;
using BaseNetCoreApi.Models.Entities;
using BaseNetCoreApi.Services;
using BaseNetCoreApi.Values;
using Microsoft.AspNetCore.Http.Extensions;

namespace BaseNetCoreApi.Service
{
    public interface IWorkContextService
    {
        public decimal NguoiDungId { get; set; }
        public int MA_NAM_HOC { get; }
        public NguoiDung NguoiDung { get; }
        public string MA_SO_GD { get; }
        public string MA_TRUONG { get; }
        public string MA_KHOI { get; }
        public string MA_PHONG_GD { get; }
        public List<GroupUserMenu> Permissons { get; }
        public bool IsRoot { get; }
        public bool IsAuthenticated { get; }
        public string RequestPath { get; }
        public string FullRequestURL { get; }

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
        private List<GroupUserMenu> _permissons;
        private int? ma_nam_hoc = null;
        private Guid? _sessionId = null;
        private decimal? _nguoiDungId = null;
        private INguoiDungService _nguoiDungService;
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
                    if (_nguoiDungService == null)
                    {
                        _nguoiDungService = _serviceProvider.GetService<INguoiDungService>()!;
                    }
                    _nguoiDung = _nguoiDungService.GetByNguoiDungId(NguoiDungId);
                }
                return _nguoiDung;
            }
        }
        public string MA_SO_GD
        {
            get
            {
                if (!string.IsNullOrEmpty(_httpContextAccessor.getCookie(UserCookieKey.MA_SO_GD)))
                {
                    return _httpContextAccessor.getCookie(UserCookieKey.MA_SO_GD)!;
                }
                else
                {
                    _httpContextAccessor.setCookie(UserCookieKey.MA_SO_GD, NguoiDung?.MaSoGd ?? "");
                    return NguoiDung?.MaSoGd ?? "";
                }
            }
        }
        public string MA_TRUONG
        {
            get
            {
                if (!string.IsNullOrEmpty(_httpContextAccessor.getCookie(UserCookieKey.MA_TRUONG)))
                {
                    return _httpContextAccessor.getCookie(UserCookieKey.MA_TRUONG)!;
                }
                else
                {
                    _httpContextAccessor.setCookie(UserCookieKey.MA_TRUONG, NguoiDung?.MaTruong ?? "");
                    return NguoiDung?.MaTruong ?? "";
                }
            }
        }
        public string MA_KHOI
        {
            get
            {
                return _httpContextAccessor.getCookie(UserCookieKey.MA_KHOI) ?? "";
            }
        }
        public string MA_PHONG_GD
        {
            get
            {
                return _httpContextAccessor.getCookie(UserCookieKey.MA_PHONG_GD) ?? "";
            }
        }
        public bool IsRoot
        {
            get
            {
                return NguoiDung.IsRoot == 1 || NguoiDung.IsMasterRootSys == 1 || NguoiDung.IsRoot == 1;
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
                return _httpContextAccessor?.HttpContext?.Request.GetDisplayUrl() ?? "" ;
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
                    var permissionPath =  RequestPath.Substring(0, RequestPath.LastIndexOf("/"));
                    _permissons = _permissionService.GetGroupUserMenuByNguoiDungByPathByTruongBySo(_nguoiDungId!.Value, permissionPath, MA_TRUONG, MA_SO_GD);
                }
                return _permissons;
            }
        }
    }
}
