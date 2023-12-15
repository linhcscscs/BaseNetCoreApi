using BaseNetCoreApi.Services;
using BaseNetCoreApi.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BaseNetCoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class NguoiDungController : ControllerBase
    {
        private readonly ILogger<NguoiDungController> _logger;
        private readonly INguoiDungService _nguoiDungService;

        public NguoiDungController(ILogger<NguoiDungController> logger, INguoiDungService nguoiDungService)
        {
            _logger = logger;
            _nguoiDungService = nguoiDungService;
        }

        [HttpGet]
        public IActionResult Get(decimal Id)
        {
            try
            {
                var ret = _nguoiDungService.GetByNguoiDungId(Id);
                return Ok(ret);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}