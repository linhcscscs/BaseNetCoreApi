namespace BaseNetCoreApi.Models.Model.CSDLBO
{
    public class DongBoRequest
    {
        public string ma_tinh { get; set; }
        public string ma_so { get; set; }
        public string ma_phong { get; set; }
        public string ma_huyen { get; set; }
        public string ma_truong { get; set; }
        public string ma_cap_hoc { get; set; }
        public int nam_hoc { get; set; }
        public string ma_xa { get; set; }
    }
    public class ResponseData<T>
    {
        public string error { get; set; }
        public string message { get; set; }
        public T data { get; set; }
        public int status { get; set; }
        public int total { get; set; }
        public int total_row { get; set; }
    }
    public class TokenResponse
    {
        public string access_token { get; set; }
        public int status { get; set; }
    }
    public class ErrorResponse
    {
        public string ma_can_bo { get; set; }
        public string ma_giao_vien { get; set; }
        public string ma_hoc_sinh { get; set; }
        public string ma_mon_hoc { get; set; }
        public decimal guid { get; set; }


        public string error_message { get; set; }
    }
}
