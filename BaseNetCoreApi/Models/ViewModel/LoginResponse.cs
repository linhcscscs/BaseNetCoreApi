namespace BaseNetCoreApi.Models.ViewModel
{
    public class LoginResponse : IResponseData
    {
        public string? AccessToken {  get; set; }
        public string? RefreshToken {  get; set; }
    }
}
