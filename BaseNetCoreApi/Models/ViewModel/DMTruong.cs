namespace BaseNetCoreApi.Models.ViewModel
{
    public class DMTruong
    {
        public decimal Id {  get; set; }
        public string Ten {  get; set; }
        public string Ma {  get; set; }
        public string? MaSoGd {  get; set; }
         public decimal? IdPhongGd { get; set; }
        public string? MaPhongGd { get; set; }
        public string? MaTinh { get; set; }
        public decimal? IdHuyen { get; set; }
        public string? MaHuyen { get; set; }
        public decimal? IdXa { get; set; }
        public string? MaXa { get; set; }
        public int? IsCapMn { get; set; }
        public int? IsCapTh { get; set; }
        public int? IsCapThcs { get; set; }
        public int? IsCapThpt { get; set; }
        public int? IsCapGdtx { get; set; }
        public string? DiaChi { get; set; }
    }
}
