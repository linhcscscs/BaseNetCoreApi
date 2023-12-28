using BaseNetCoreApi.Models.PHO_CAP_GDEntities;

namespace BaseNetCoreApi.Services.Interface
{
    public interface IPermissionService
    {
        GroupUser? GetGroupUserByNguoiDung(decimal nguoiDungId);
        List<GroupUserMenu> GetGroupUserMenuByNguoiDung(decimal nguoiDungId);
        List<GroupUserMenu> GetGroupUserMenuByNguoiDungByPath(decimal nguoiDungId, string path);
    }
}
