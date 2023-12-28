using BaseNetCoreApi.Values;
using System.ComponentModel.DataAnnotations;

namespace BaseNetCoreApi.Models.ViewModel
{
    public class DongBoDanhMucRequest
    {
        public string MaCapHoc { get; set; } = "";
        public string MaTinh {  get; set; } = "";
        public string MaHuyen {  get; set; } = "";
        public bool IsSyncDMPhong {  get; set; }
        public bool IsSyncDMHuyen {  get; set; }
        public bool IsSyncDMXa {  get; set; }
        public bool IsSyncDSTruong {  get; set; }
    }
    public class DongBoDanhMucResponse
    {
        public ReturnCode? SyncDMPhong { get; set; } = null;
        public ReturnCode? SyncDMHuyen { get; set; } = null;
        public ReturnCode? SyncDMXa { get; set; } = null;
        public ReturnCode? SyncDSTruong { get; set; } = null;
    }
}
