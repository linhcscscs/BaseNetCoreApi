namespace BaseNetCoreApi.Models.Model
{
    public class GetDmXaFilter
    {
        public List<string> list_ma_tinh { get; set; }
        public List<string> list_ma_huyen { get; set; }
        public string ten_xa {  get; set; }
        public string ma_xa { get; set; }
    }
}
