using BaseNetCoreApi.Models.Entities;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Values;

namespace BaseNetCoreApi.Services.Interface
{
    public interface IPermissionService
    {
        List<DSNhomQuyenViewModel> GetDsNhomQuyen(DSNhomQuyenRequest model);
        (string? filePath, string? fileName) GetDsNhomQuyenExcel(DSNhomQuyenRequest model);
        ReturnCode EditDsNhomQuyen(DSNhomQuyenEditModel model);
        ReturnCode DeleteDsNhomQuyen(DSNhomQuyenDeleteModel model);
        ReturnCode GetGroupUserMenuEntity(long Id, out List<GroupUserMenuEntity> result);
        ReturnCode EditGroupUserMenuEntity(GroupUserMenuEntityEditViewModel model);
        GroupUser? GetGroupUserByNguoiDung(decimal nguoiDungId);
        List<GroupUserMenu> GetGroupUserMenuByNguoiDung(decimal nguoiDungId);
        List<GroupUserMenu> GetGroupUserMenuByNguoiDungByPath(decimal nguoiDungId, string path);
    }
}
