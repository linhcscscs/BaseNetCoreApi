using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.AttributeCollection;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Services;
using BaseNetCoreApi.Services.Interface;
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
        public PermissionController(
            INguoiDungService nguoiDungService)
        {
            _nguoiDungService = nguoiDungService;
        }
        #endregion

        //[HasPermission(SysTypeAccess.View | SysTypeAccess.Add)]
        [HttpGet("GetAllTest/Baocao123")]
        public IActionResult GetAll()
        {
            return UltilHelper.ReturnSuccess(_nguoiDungService.GetByNguoiDungId(1));
        }
    }
}
