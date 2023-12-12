using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.AttributeCollection;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Services;
using BaseNetCoreApi.Values;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BaseNetCoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PermissionController : ControllerBase
    {
        #region Contructor
        private INguoiDungService _nguoiDungService;
        private IPermissionService _permissionService;
        public PermissionController(INguoiDungService nguoiDungService, 
            IPermissionService permissionService)
        {
            _nguoiDungService = nguoiDungService;
            _permissionService = permissionService;
        }
        #endregion

        [HasPermission(SysTypeAccess.View | SysTypeAccess.Add)]
        [HttpGet("GetAllTest/Baocao123")]
        public IActionResult GetAll()
        {
            return UltilHelper.ReturnSuccess();
        }
    }
}
