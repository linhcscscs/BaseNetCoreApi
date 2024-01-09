using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.AttributeCollection;
using BaseNetCoreApi.Models.Repository;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Services;
using BaseNetCoreApi.Services.Interface;
using BaseNetCoreApi.Values;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BaseNetCoreApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class NhomQuyenController : ControllerBase
    {
        #region Contructor
        private IPermissionService _permissionService;
        private ILogger<NhomQuyenController> _logger;
        public NhomQuyenController(
            IPermissionService permissionService,
            ILogger<NhomQuyenController> logger)
        {
            _permissionService = permissionService;
            _logger = logger;
        }
        #endregion

        [HttpPost]
        [HasPermission(SysTypeAccess.View & (SysTypeAccess.Add | SysTypeAccess.Edit))]
        public IActionResult DSNhomQuyen([FromBody] DSNhomQuyenRequest model)
        {
            try
            {
                var result = _permissionService.GetDsNhomQuyen(model);
                return ReturnHelper.ReturnSuccess(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "DSNhomQuyen");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        [HttpPost]
        [HasPermission(SysTypeAccess.View & (SysTypeAccess.Add | SysTypeAccess.Edit))]
        public IActionResult DSNhomQuyenExportExcel([FromBody] DSNhomQuyenRequest model)
        {
            try
            {
                var result = _permissionService.GetDsNhomQuyenExcel(model);
                return this.ReturnFile(result.filePath, result.fileName);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "DSNhomQuyen");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        [HttpPost]
        [HasPermission(SysTypeAccess.View & (SysTypeAccess.Add | SysTypeAccess.Edit))]
        public IActionResult AddDSNhomQuyen([FromBody] List<DSNhomQuyenViewModel> model)
        {
            try
            {
                var ret = _permissionService.AddDsNhomQuyen(model, out var result);
                if (ret.Success)
                {
                    return ReturnHelper.ReturnSuccess(result);
                }
                else
                {
                    return ReturnHelper.ReturnErrorStatusCode(ret);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "AddDSNhomQuyen");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        [HttpGet]
        [HasPermission(SysTypeAccess.View)]
        public IActionResult AddDSNhomQuyenExcelTemplate()
        {
            try
            {
                var path = ConfigurationHelper.ServerMapPath + "/ExportTemplates/NhomQuyen.xlsx";
                return this.ReturnFile(path, "NhomQuyen.xlsx", false);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "AddDSNhomQuyen");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        [HttpPost]
        [HasPermission(SysTypeAccess.View & (SysTypeAccess.Add | SysTypeAccess.Edit))]
        public IActionResult AddDSNhomQuyenExcel([FromForm] DSNhomQuyenImportExcel model)
        {
            try
            {
                var result = _permissionService.AddDsNhomQuyenExcelUploadFile(model.file);
                return ReturnHelper.ReturnSuccess(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "AddDSNhomQuyenExcel");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        [HttpPost]
        [HasPermission(SysTypeAccess.View & (SysTypeAccess.Add | SysTypeAccess.Edit))]
        public IActionResult AddDSNhomQuyenExcelResult([FromBody] DSNhomQuyenImportExcelCheckResult model)
        {
            try
            {
                var result = _permissionService.AddDsNhomQuyenExcelResult(model.FilePath);
                return ReturnHelper.ReturnSuccess(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "AddDSNhomQuyenExcelResult");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        [HttpPost]
        [HasPermission(SysTypeAccess.View & (SysTypeAccess.Add | SysTypeAccess.Edit))]
        public IActionResult AddDSNhomQuyenExcelSave([FromBody] DSNhomQuyenImportExcelSave model)
        {
            try
            {
                var ret = _permissionService.AddDsNhomQuyenExcelSave(model, out var result);
                return ReturnHelper.ReturnErrorStatusCode(ret, result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "AddDSNhomQuyenExcelResult");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        [HttpPost]
        [HasPermission(SysTypeAccess.View & SysTypeAccess.Edit)]
        public IActionResult EditDSNhomQuyen([FromBody] DSNhomQuyenEditModel model)
        {
            try
            {
                var ret = _permissionService.EditDsNhomQuyen(model);
                return ReturnHelper.ReturnErrorStatusCode(ret);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "EditDSNhomQuyen");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        [HttpPost]
        [HasPermission(SysTypeAccess.View & SysTypeAccess.Delete)]
        public IActionResult DeleteDSNhomQuyen([FromBody] DSNhomQuyenDeleteModel model)
        {
            try
            {
                var ret = _permissionService.DeleteDsNhomQuyen(model);
                return ReturnHelper.ReturnErrorStatusCode(ret);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "DeleteDSNhomQuyen");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }

        [HttpGet]
        [HasPermission(SysTypeAccess.View)]
        public IActionResult GetTrangThaiValue()
        {
            try
            {
                var result = TrangThaiValue.getList();
                return ReturnHelper.ReturnSuccess(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetTrangThaiValue");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }

        [HttpGet]
        [HasPermission(SysTypeAccess.View)]
        public IActionResult ChiTietNhomQuyen(long Id)
        {
            try
            {
                var ret = _permissionService.GetGroupUserMenuEntity(Id, out var result);
                if (ret.Success)
                {
                    return ReturnHelper.ReturnSuccess(result);
                }
                return ReturnHelper.ReturnErrorStatusCode(ret);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ChiTietNhomQuyen");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        [HttpPost]
        [HasPermission(SysTypeAccess.View & SysTypeAccess.Edit)]
        public IActionResult EditChiTietNhomQuyen([FromBody] GroupUserMenuEntityEditViewModel model)
        {
            try
            {
                var ret = _permissionService.EditGroupUserMenuEntity(model);
                return ReturnHelper.ReturnErrorStatusCode(ret);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "EditChiTietNhomQuyen");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
    }
}
