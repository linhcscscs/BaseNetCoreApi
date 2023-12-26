using System.ComponentModel.DataAnnotations;

namespace BaseNetCoreApi.Models.ViewModel
{
    public class HoSoXaDetailViewModel
    {
        public string MaPhuongXa {  get; set; }
        public string TinhThanhPho {  get; set; }
        public string QuanHuyen {  get; set; }
        public string TenPhuongXa { get; set; }
        public int ThuTu {  get; set; }
        public bool HienThuocVungKhoKhan {  get; set; }
    }
    public class HoSoXaDetailEditViewModel
    {
        [Required(ErrorMessage = "HienThuocVungKhoKhan is required")]
        public bool HienThuocVungKhoKhan { get; set; }
    }

}
