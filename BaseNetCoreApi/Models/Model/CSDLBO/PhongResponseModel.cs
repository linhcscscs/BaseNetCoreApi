namespace BaseNetCoreApi.Models.Model.CSDLBO
{
    public class PhongResponseModel
    {
        public decimal id { get; set; }
        public string ma { get; set; }
        public int ma_nam_hoc { get; set; }
        public string ma_so_gd { get; set; }
        public string ten { get; set; }
        public string ma_tinh { get; set; }
        public decimal? id_huyen { get; set; }
        public string ma_huyen { get; set; }
        public string dia_chi { get; set; }
        public string dien_thoai { get; set; }
        public string email { get; set; }
        public string fax { get; set; }
        public string website { get; set; }
        public string truong_phong { get; set; }
        public string dien_thoai_truong_phong { get; set; }
        public string email_truong_phong { get; set; }
        public string can_bo_phu_trach { get; set; }
        public string dien_thoai_can_bo_phu_trach { get; set; }
        public string email_can_bo_phu_trach { get; set; }
        public int? thu_tu { get; set; }
        public int? trang_thai { get; set; }
        public decimal? nguoi_sua { get; set; }
        public DateTime? ngay_sua { get; set; }
        public decimal? nguoi_tao { get; set; }
        public DateTime? ngay_tao { get; set; }
        public decimal id_source { get; set; }
    }
}
