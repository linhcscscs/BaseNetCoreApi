using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.ViewModel;

namespace BaseNetCoreApi.Services.Interface
{
    public interface INguoiDungService
    {
        public NguoiDung? GetByNguoiDungId(decimal id);
        NguoiDung? GetByUsernameAndPassword(LoginRequest model);
    }
}
