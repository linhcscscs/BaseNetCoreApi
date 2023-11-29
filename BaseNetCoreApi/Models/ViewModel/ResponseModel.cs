using BaseNetCoreApi.Values;

namespace BaseNetCoreApi.Models.ViewModel
{
    public class ResponseModel
    {
        public ResponseModel(EReturnCode eReturnCode)
        {
            var ret = new ReturnCode(eReturnCode);
            ErrorCode = ret.ErrorCode;
            ErrorMessage = ret.ErrorMsg;
        }
        public ResponseModel(ReturnCode ret) {
            ErrorCode = ret.ErrorCode;
            ErrorMessage = ret.ErrorMsg;
        }
        public ResponseModel(object? data)
        {
            Data = data;
        }
        public bool Success
        {
            get
            {
                return string.IsNullOrEmpty(ErrorCode);
            }
        }
        public string? ErrorCode { get; set; }
        public string? ErrorMessage { get; set; }
        public object? Data { get; set; } = null;
    }
}
