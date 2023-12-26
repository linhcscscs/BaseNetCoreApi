using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.AttributeCollection;
using BaseNetCoreApi.Models.Repository;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Services;
using BaseNetCoreApi.Values;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BaseNetCoreApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PhuongXaController : ControllerBase
    {
        private IDanhMucService _danhMucService;
        public PhuongXaController(
            IDanhMucService danhMucService
            )
        {
            _danhMucService = danhMucService;
        }
        [HttpGet]
        [HasPermission(SysTypeAccess.View)]
        public IActionResult HoSoXaDetailViewModel()
        {
            try
            {
                var result = _danhMucService.GetHoSoXaDetailViewModel();
                return ReturnHelper.ReturnSuccess(result);
            }
            catch
            {
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        [HttpPost]
        //[HasPermission(SysTypeAccess.Edit)]
        [AllowAnonymous]
        public IActionResult HoSoXaDetailViewModel(HoSoXaDetailEditViewModel model)
        {
            try
            {
                var ret = _danhMucService.UpdateHoSoXaDetail(model);
                if (ret.Success)
                {
                    return ReturnHelper.ReturnSuccess();
                }
                else { 
                    return ReturnHelper.ReturnErrorStatusCode(ret); 
                }
                
            }
            catch
            {
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
    }
}
