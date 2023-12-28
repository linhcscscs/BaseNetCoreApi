using System.ComponentModel.DataAnnotations;

namespace BaseNetCoreApi.Models.ViewModel
{
    public class ChonXaLamViecRequest
    {
        [Required(ErrorMessage = "NguoiDungId is required")]
        public int NguoiDungId { get; set; }
        [Required(ErrorMessage = "Refresh Token is required")]
        public string RefreshToken { get; set; }
        [Required(ErrorMessage = "MaTinh Token is required")]
        public string MaTinh { get; set; }
        [Required(ErrorMessage = "MaHuyen Token is required")]
        public string MaHuyen { get; set; }
        [Required(ErrorMessage = "MaXa Token is required")]
        public string MaXa { get; set; }
    }
}
