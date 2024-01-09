namespace BaseNetCoreApi.Models.Entities
{
    public class NguoiDungToThonEntity
    {
        public decimal ID_NGUOI_DUNG { get; set; }
        public decimal ID_TO_THON { get; set; }
        public string MA_TO_THON { get; set; }
        public string TEN_TO_THON { get; set; }
        public int? TRANG_THAI { get; set; }
        public bool TRANG_THAI_HIEN_THI { get; set; }
    }
}
