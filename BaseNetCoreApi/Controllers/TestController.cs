using BaseNetCoreApi.Helper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BaseNetCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpPost]
        public IActionResult SaveAndReturnFile([FromForm] TestUpload testUpload)
        {
            var ret = UltilHelper.SaveTempExcelStaticFile(testUpload.file, out var filePath);
            if (ret.Success)
            {
                return this.ReturnFile(filePath, "TestUpload.xlsx");
            }
            else
            {
                return UltilHelper.ReturnErrorStatusCode(ret);
            }
        }
        public class TestUpload
        {
            public IFormFile file { get; set; }
        }
    }
}