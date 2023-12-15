using System.ComponentModel.DataAnnotations;

namespace BaseNetCoreApi.Models.ViewModel
{
    public class RefreshAccessTokenRequest
    {
        [Required(ErrorMessage = "NguoiDungId is required")]
        public int NguoiDungId {  get; set; }
        [Required(ErrorMessage = "Refresh Token is required")]
        public string RefreshToken {  get; set; }
        public string ma_tinh { get; set; }
        [Required(ErrorMessage = "ma_huyen is required")]
        public string ma_huyen { get; set; }
        [Required(ErrorMessage = "ma_xa is required")]
        public string ma_xa { get; set; }
    }
}
