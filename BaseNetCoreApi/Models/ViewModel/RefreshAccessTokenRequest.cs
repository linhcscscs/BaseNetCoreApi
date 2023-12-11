using System.ComponentModel.DataAnnotations;

namespace BaseNetCoreApi.Models.ViewModel
{
    public class RefreshAccessTokenRequest
    {
        [Required(ErrorMessage = "NguoiDungId is required")]
        public int NguoiDungId {  get; set; }
        [Required(ErrorMessage = "Refresh Token is required")]
        public string RefreshToken {  get; set; }
        public string ma_so_gd { get; set; }
        [Required(ErrorMessage = "ma_truong is required")]
        public string ma_truong { get; set; }
        [Required(ErrorMessage = "ma_khoi is required")]
        public string ma_khoi { get; set; }
        [Required(ErrorMessage = "ma_phong_gd is required")]
        public string ma_phong_gd { get; set; }
    }
}
