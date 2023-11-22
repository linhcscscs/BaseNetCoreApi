using System.ComponentModel.DataAnnotations;

namespace BaseNetCoreApi.Models.ViewModel
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }


    }
}
