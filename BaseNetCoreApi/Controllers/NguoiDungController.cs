using BaseNetCoreApi.DomainService.Interface;
using BaseNetCoreApi.Services;
using BaseNetCoreApi.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BaseNetCoreApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class NguoiDungController : ControllerBase
    {
        private readonly ILogger<NguoiDungController> _logger;
        private readonly INguoiDungService _nguoiDungService;
        private readonly IWorkContextService _workContextService;

        public NguoiDungController(ILogger<NguoiDungController> logger, INguoiDungService nguoiDungService, IWorkContextService workContextService)
        {
            _logger = logger;
            _nguoiDungService = nguoiDungService;
            _workContextService = workContextService;
        }

        [HttpGet("/[controller]/QuanLyNguoiDung/[action]")]
        public IActionResult GetListNguoiDung()
        {
            try
            {
                var ret = _nguoiDungService.GetNguoiDungViewModel(_workContextService.MA_TINH, _workContextService.MA_HUYEN, _workContextService.MA_XA);
                return Ok(ret);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}