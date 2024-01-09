using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Values;
using Microsoft.AspNetCore.Mvc;

namespace BaseNetCoreApi.Helper
{
    public static class ReturnHelper
    {
        public static IActionResult ReturnFile(this ControllerBase controllerBase, string filePath, string fileName, bool isDelete = true)
        {
            if (System.IO.File.Exists(filePath))
            {
                var fileOption = isDelete ? FileOptions.DeleteOnClose : FileOptions.None;
                var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None, 4096, fileOption);
                return controllerBase.File(
                        fileStream: fs,
                        contentType: System.Net.Mime.MediaTypeNames.Application.Octet,
                        fileDownloadName: fileName);
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
        public static IActionResult ReturnErrorStatusCode(ReturnCode ret, object? Data = null)
        {
            var model = new ResponseModel(ret)
            {
                Data = Data
            };
            var result = new ObjectResult(model)
            {
                StatusCode = ret.StatusCode()
            };
            return result;
        }
    }
}
