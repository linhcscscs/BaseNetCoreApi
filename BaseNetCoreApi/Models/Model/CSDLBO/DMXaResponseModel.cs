namespace BaseNetCoreApi.Models.Model.CSDLBO
{
    public class DMXaResponseModel
    {
        public decimal id { get; set; }
        public string ma { get; set; }
        public int ma_nam_hoc { get; set; }
        public string ma_tinh { get; set; }
        public decimal? id_huyen { get; set; }
        public string ma_huyen { get; set; }
        public string ten { get; set; }
        public int? thu_tu { get; set; }
        public decimal? nguoi_tao { get; set; }
        public DateTime? ngay_tao { get; set; }
        public decimal? nguoi_sua { get; set; }
        public DateTime? ngay_sua { get; set; }
        public string cap { get; set; }
        public string ma_xa_sap_nhap { get; set; }
        public decimal id_source { get; set; }
    }
}
