using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.ContextProvider;
using BaseNetCoreApi.Models.Dtos;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BaseNetCoreApi.Controllers
{
    public class CommonController : ControllerBase
    {
        #region Contructor
        private ICommonService _commonService;
        private ILogger<CommonController> _logger;
        public CommonController(ICommonService commonService, ILogger<CommonController> logger)
        {
            _commonService = commonService;
            _logger = logger;
        }

        [Route("/DMSoGd")]
        [HttpPost]
        [AllowAnonymous]
        public IActionResult GetDMSoGd([FromBody]PaginationRequest<DMSoGdRequestDto> model)
        {
            try
            {
                return UltilHelper.ReturnSuccess(_commonService.GetDMSoGd(model));
            }
            catch (Exception ex)
            {
                _logger.LogError("CommonController.GetDMSoGd", ex);
                return UltilHelper.ExceptionErrorStatus500;
            }
        }

        [Route("/DMPhongGd")]
        [HttpPost]
        [AllowAnonymous]
        public IActionResult GetDMPhongGd([FromBody] PaginationRequest<DMPhongGdRequestDto> model)
        {
            try
            {
                return UltilHelper.ReturnSuccess(_commonService.GetDMPhongGd(model));
            }
            catch (Exception ex)
            {
                _logger.LogError("CommonController.GetDMPhongGd", ex);
                return UltilHelper.ExceptionErrorStatus500;
            }
        }

        [Route("/DMTruong")]
        [HttpPost]
        [AllowAnonymous]
        public IActionResult GetDMTruong([FromBody] PaginationRequest<DMTruongRequestDto> model)
        {
            try
            {
                return UltilHelper.ReturnSuccess(_commonService.GetDMTruong(model));
            }
            catch (Exception ex)
            {
                _logger.LogError("CommonController.GetDMTruong", ex);
                return UltilHelper.ExceptionErrorStatus500;
            }
        }

        [Route("/DMCapHoc")]
        [HttpPost]
        [AllowAnonymous]
        public IActionResult GetDMCapHoc()
        {
            try
            {
                return UltilHelper.ReturnSuccess(_commonService.GetDMCapHoc());
            }
            catch (Exception ex)
            {
                _logger.LogError("CommonController.GetDMCapHoc", ex);
                return UltilHelper.ExceptionErrorStatus500;
            }
        }
        #endregion
    }
}
