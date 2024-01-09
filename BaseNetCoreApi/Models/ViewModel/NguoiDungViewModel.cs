namespace BaseNetCoreApi.Models.ViewModel
{
    public class NguoiDungViewModel
    {
        public decimal NguoiDungId {  get; set; }
        public string? TenDangNhap {  get; set; }
        public string? HoTen {  get; set; }
        public decimal? GroupUserId {  get; set; }
        public bool? IsRoot {  get; set; }
        public int? TrangThai {  get; set; }
        public List<string> ListMaToThonPhuTrach {  get; set; }
    }
}
