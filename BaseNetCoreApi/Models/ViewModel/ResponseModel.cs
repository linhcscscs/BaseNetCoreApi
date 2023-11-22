namespace BaseNetCoreApi.Models.ViewModel
{
    public class ResponseModel
    {
        public bool Success
        {
            get
            {
                return string.IsNullOrEmpty(ErrorCode);
            }
        }
        public string? ErrorCode { get; set; }
        public string? ErrorMessage { get; set; }
        public IResponseData? Data { get; set; } = null;
    }
    public class IResponseData
    {

    }
}
