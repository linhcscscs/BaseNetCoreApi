using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.AttributeCollection;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Models.Collection.Interface;
using BaseNetCoreApi.Models.Dtos;
using BaseNetCoreApi.Models.Model;
using BaseNetCoreApi.Models.Repository;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Services;
using BaseNetCoreApi.Services.Interface;
using BaseNetCoreApi.Values;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BaseNetCoreApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [HasPermission(SysTypeAccess.IsMasterRoot)]
    public class ManagerController : ControllerBase
    {
        #region Contructor
        private ILogger<ManagerController> _logger;
        private IAuthenticateService _authenticateService;
        private IQiCache _qiCache;
        private ILogSYSCollection _logSYSCollection;
        private IMenuRepository _menuRepository;
        private IMenuService _menuService;
        private IDongBoDanhMucService _dongBoDanhMucService;
        public ManagerController(ILogger<ManagerController> logger,
                                 IAuthenticateService authenticateService,
                                 IQiCache qiCache,
                                 ILogSYSCollection logSYSCollection,
                                 IMenuRepository menuRepository,
                                 IMenuService menuService,
                                 IDongBoDanhMucService dongBoDanhMucService
            )
        {
            _logger = logger;
            _authenticateService = authenticateService;
            _qiCache = qiCache;
            _logSYSCollection = logSYSCollection;
            _menuRepository = menuRepository;
            _menuService = menuService;
            _dongBoDanhMucService = dongBoDanhMucService;
        }
        #endregion

        #region API
        #region Chọn xã làm việc
        [HttpPost]
        public IActionResult ChonXa([FromBody] ChonXaLamViecRequest model)
        {
            try
            {
                var ret = _authenticateService.ChonXa(model, out var authResponse);
                if (ret.Success)
                {
                    return ReturnHelper.ReturnSuccess(authResponse);
                }
                else
                {
                    return ReturnHelper.ReturnErrorStatusCode(ret);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ChonXa", [model]);
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        #endregion
        #region Quản lý cache
        [HttpGet]
        public IActionResult ManageCache()
        {
            try
            {
                return ReturnHelper.ReturnSuccess(_qiCache.GetAllKey());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ManageCache.Get");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }

        [HttpDelete]
        public IActionResult ManageCache([FromBody] List<string> CacheKeys)
        {
            try
            {
                _qiCache.Remove(CacheKeys);
                return ReturnHelper.ReturnSuccess();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ManageCache.Delete");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        #endregion
        #region Log hệ thống
        [HttpPost]
        public IActionResult DSLogSys([FromBody] PaginationRequest<GetLogSysFilter> model)
        {
            try
            {
                var result = _logSYSCollection.GetLog(model);
                return ReturnHelper.ReturnSuccess(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "DSLogSys");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        [HttpGet("/[controller]/DSLogSys/[action]")]
        public IActionResult GetHanhDong()
        {
            try
            {
                var result = UltilHelper.GetFieldValues(typeof(LogType)).Select(s => s.Value).ToList();
                return ReturnHelper.ReturnSuccess(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "DSLogSys");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        #endregion
        #region Quản lý menu
        [HttpGet("/[controller]/Menu")]
        public IActionResult GetMenuList()
        {
            try
            {
                var result = _menuRepository.GetMenuAdminViewModels();
                return ReturnHelper.ReturnSuccess(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetMenuList");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        [HttpPost("/[controller]/Menu/[action]")]
        public IActionResult AddMenu([FromBody] List<MenuAddViewModel> model)
        {
            try
            {
                var result = _menuService.InsertMenu(model);
                return ReturnHelper.ReturnSuccess(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "AddNewMenu");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        [HttpDelete("/[controller]/Menu/[action]")]
        public IActionResult DeleteMenu([FromBody] List<MenuDeleteViewModel> model)
        {
            try
            {
                var result = _menuService.DeleteMenu(model);
                return ReturnHelper.ReturnSuccess(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "DeleteMenu");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        [HttpPost("/[controller]/Menu/[action]")]
        public IActionResult UpdateMenu([FromBody] List<MenuUpdateViewModel> model)
        {
            try
            {
                var result = _menuService.UpdateMenus(model);
                return ReturnHelper.ReturnSuccess(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UpdateMenu");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        #endregion
        #region Đồng bộ danh mục
        [HttpPost]
        public async Task<IActionResult> DongBo([FromBody] DongBoDanhMucRequest model)
        {
            try
            {
                var result = await _dongBoDanhMucService.DongBoDanhMuc(model);
                return ReturnHelper.ReturnSuccess(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "AddNewMenu");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        #endregion
        #endregion
    }
}
