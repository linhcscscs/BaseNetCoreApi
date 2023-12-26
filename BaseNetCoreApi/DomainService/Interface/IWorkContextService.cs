using BaseNetCoreApi.Models.PHO_CAP_GDEntities;

namespace BaseNetCoreApi.DomainService.Interface
{
    public interface IWorkContextService
    {
        public decimal NguoiDungId { get; set; }
        public int MA_NAM_HOC { get; }
        public NguoiDung NguoiDung { get; }
        public string MA_TINH { get; set; }
        public string MA_HUYEN { get; set; }
        public string MA_XA { get; set; }
        public List<GroupUserMenu> Permissons { get; }
        public bool IsRoot { get; }
        public bool IsRootSys { get; }
        public bool IsAuthenticated { get; }
        public string RequestPath { get; }
        public string FullRequestURL { get; }
        public IHttpContextAccessor HttpContextAccessor { get; }
    }
}
