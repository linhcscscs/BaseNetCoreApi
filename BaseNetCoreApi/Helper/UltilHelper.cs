using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Values;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Mail;


namespace BaseNetCoreApi.Helper
{
    public static class UltilHelper
    {
        public static List<string> ConvertStringToListString(string stringValue)
        {
            return stringValue.Split(new char[] { ',' }).ToList();
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
        public static byte[] StreamToByteArray(string fileName)
        {
            try
            {
                var total_stream = new byte[0];
                using (Stream input = File.Open(fileName, FileMode.Open, FileAccess.Read))
                {
                    var stream_array = new byte[0];
                    var buffer = new byte[1024];
                    int read = 0;

                    while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        stream_array = new byte[total_stream.Length + read];
                        total_stream.CopyTo(stream_array, 0);
                        Array.Copy(buffer, 0, stream_array, total_stream.Length, read);
                        total_stream = stream_array;
                    }
                }
                return total_stream;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static IActionResult ReturnFile(this ControllerBase controllerBase, string filePath, string fileName)
        {
            if (System.IO.File.Exists(filePath))
            {
                return controllerBase.File(System.IO.File.OpenRead(filePath), "application/octet-stream", fileName);
            }
            return controllerBase.NotFound();
        }
        public static ReturnCode SaveTempExcelStaticFile(IFormFile file, out string filePath)
        {
            var ret = new ReturnCode();
            filePath = "";
            if (file == null || file.Length == 0)
            {
                ret = new ReturnCode(EReturnCode.NoFileUploaded);
                return ret;
            }
            var fileExtension = System.IO.Path.GetExtension(file.FileName);
            var filename = file.FileName + Guid.NewGuid().ToString();
            if (fileExtension.ToLower() != ".xls" && fileExtension.ToLower() != ".xlsx")
            {
                ret = new ReturnCode(EReturnCode.FileExtensionInvalid);
                return ret;
            }
            filePath = ConfigurationHelper.FileFolerInternalURL + "/" + filename + fileExtension;
            return SaveStaticFile(file, filePath);
        }
        public static ReturnCode SaveStaticFile(IFormFile file, string filePath)
        {
            var ret = new ReturnCode();
            try
            {
                using (var stream = System.IO.File.Create(filePath))
                {
                    file.CopyTo(stream);
                }
            }
            catch
            {
                ret = new ReturnCode(EReturnCode.InternalErrorException);
            }
            return ret;
        }
    }
}
