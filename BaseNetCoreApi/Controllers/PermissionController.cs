using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.AttributeCollection;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static BaseNetCoreApi.Values.ScopePermission;

namespace BaseNetCoreApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
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

        [HasPermission(EScopePermission.TestAPI_R & EScopePermission.TestAPI_W)]
        [HttpGet]
        public IActionResult GetAll()
        {
            return UltilHelper.ReturnSuccess(_permissionService.GetPermissonEntities());
        }
    }
}
