using System.ComponentModel.DataAnnotations;

namespace BaseNetCoreApi.Models.ViewModel
{
    public class RefreshAccessTokenRequest
    {
        [Required(ErrorMessage = "Refresh Token is required")]
        public string RefreshToken {  get; set; }
    }
}
