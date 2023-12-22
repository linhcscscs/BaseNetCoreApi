using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Values;
using Microsoft.AspNetCore.Mvc;

namespace BaseNetCoreApi.Helper
{
    public static class ReturnHelper
    {
        public static IActionResult ReturnFile(this ControllerBase controllerBase, string filePath, string fileName)
        {
            if (System.IO.File.Exists(filePath))
            {
                return controllerBase.File(System.IO.File.OpenRead(filePath), "application/octet-stream", fileName);
            }
            return controllerBase.NotFound();
        }

        public static IActionResult ReturnSuccess(object? responseData = null)
        {
            return new OkObjectResult(new ResponseModel(responseData));
        }

        public static IActionResult ExceptionErrorStatus500
        {
            get
            {
                return ReturnErrorStatusCode(new ReturnCode(EReturnCode.InternalErrorException));
            }
        }

        public static IActionResult ReturnErrorStatusCode(ReturnCode ret)
        {
            var model = new ResponseModel(ret);
            var result = new ObjectResult(model)
            {
                StatusCode = ret.StatusCode()
            };
            return result;
        }
    }
}
