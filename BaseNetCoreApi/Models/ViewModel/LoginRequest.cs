using System.ComponentModel.DataAnnotations;

namespace BaseNetCoreApi.Models.ViewModel
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "ma_tinh is required")]
        public string ma_tinh { get; set; }
        [Required(ErrorMessage = "ma_huyen is required")]
        public string ma_huyen { get; set; }
        [Required(ErrorMessage = "ma_xa is required")]
        public string ma_xa { get; set; }
    }
}
