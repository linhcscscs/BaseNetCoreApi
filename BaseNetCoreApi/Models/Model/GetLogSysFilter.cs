namespace BaseNetCoreApi.Models.Model
{
    public class GetLogSysFilter
    {
        public string? MaTinh {  get; set; }
        public string? MaHuyen {  get; set; }
        public string? MaXa {  get; set; }
        public string? TenBang {  get; set; }
        public string? HanhDong {  get; set; }
        public DateTime? FromDate {  get; set; }
        public DateTime? ToDate { get; set; }
    }
}
