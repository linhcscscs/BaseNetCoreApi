using BaseNetCoreApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BaseNetCoreApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NguoiDungController : ControllerBase
    {
        private readonly ILogger<NguoiDungController> _logger;
        private readonly INguoiDungService _nguoiDungService;

        public NguoiDungController(ILogger<NguoiDungController> logger, INguoiDungService nguoiDungService)
        {
            _logger = logger;
            _nguoiDungService = nguoiDungService;
        }

        [HttpGet()]
        public IActionResult Get(int ma_nam_hoc, decimal Id )
        {
            try
            {
                var ret = _nguoiDungService.GetByNguoiDungId(Id, ma_nam_hoc);
                return Ok(ret);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}