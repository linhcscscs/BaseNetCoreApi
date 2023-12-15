namespace BaseNetCoreApi.Models.ViewModel
{
    public class AuthResponse
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
        public decimal NguoiDungId {  get; set; }
        public bool IsRoot { get; set; }
        public bool IsRootSys { get; set; }
        public List<GroupUserPermission>? Permissions { get; set; }
        public partial class GroupUserPermission
        {
            public decimal MenuId { get; set; }
            public int? MenuLevel { get; set; }
            public string? MenuNameEg { get; set; }
            public string? URL { get; set; }
            public string? MenuName { get; set; }
            public bool IsView { get; set; }
            public bool IsAdd { get; set; }
            public bool IsEdit { get; set; }
            public bool IsDelete { get; set; }
            public bool IsUpload { get; set; }
            public bool IsAuth { get; set; }
        }
    }
}
