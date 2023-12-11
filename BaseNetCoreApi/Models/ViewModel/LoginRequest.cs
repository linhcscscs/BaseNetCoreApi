using System.ComponentModel.DataAnnotations;

namespace BaseNetCoreApi.Models.ViewModel
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "ma_so_gd is required")]
        public string ma_so_gd { get; set; }
        [Required(ErrorMessage = "ma_truong is required")]
        public string ma_truong { get; set; }
        [Required(ErrorMessage = "ma_khoi is required")]
        public string ma_khoi { get; set; }
        [Required(ErrorMessage = "ma_phong_gd is required")]
        public string ma_phong_gd { get; set; }
    }
}
