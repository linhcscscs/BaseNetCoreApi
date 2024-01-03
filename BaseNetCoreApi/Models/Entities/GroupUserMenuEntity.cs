namespace BaseNetCoreApi.Models.Entities
{
    public class GroupUserMenuEntity
    {
        public long MenuID { get; set; }
        public long? ParentID { get; set; }
        public string? MenuCode { get; set; }
        public string? MenuName { get; set; }
        public string? Link {  get; set; }
        public decimal? GroupUserMenuID { get; set; }
        public long? GroupUserID { get; set; }
        public int? IsView { get; set; }
        public int? IsAdd { get; set; }
        public int? IsEdit { get; set; }
        public int? IsDelete { get; set; }
        public int? IsUpload { get; set; }
        public int? IsAuth { get; set; }
    }
}
