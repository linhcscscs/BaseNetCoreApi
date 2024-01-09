using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.ViewModel;

namespace BaseNetCoreApi.Services.Interface
{
    public interface INguoiDungService
    {
        List<NguoiDungViewModel> GetNguoiDungViewModel(string maTinh, string maHuyen, string maXa);
        NguoiDung? GetByUsernameAndPassword(LoginRequest model);
    }
}
