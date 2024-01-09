namespace BaseNetCoreApi.Models.ViewModel
{
    public class DSNhomQuyenRequest
    {
        public string MaNhomQuyen { get; set; }
        public string TenNhomQuyen { get; set; }
    }
    public class DSNhomQuyenViewModel
    {
        public long GroupUserId {  get; set; }
        public string Ma { get; set; }
        public string Ten {  get; set; }
        public bool IsQuanTri {  get; set; }
        public int Status {  get; set; }
    }

    public class DSNhomQuyenEditModel
    {
        public List<DSNhomQuyenViewModel> Data { get; set; }
    }
    public class DSNhomQuyenDeleteModel
    {
        public List<long> ListId { get; set; }
    }
    public class DSNhomQuyenImportExcel
    {
        public IFormFile file { get; set; }
    }
    public class DSNhomQuyenImportExcelCheckResult
    {
        public string FilePath { get; set; }
    }
    public class DSNhomQuyenImportExcelSave
    {
        public bool UpdateIfExists {  get; set; }
        public string FilePath { get; set; }
    }
}
