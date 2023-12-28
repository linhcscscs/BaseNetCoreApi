using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Models.Model.CSDLBO;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Values;

namespace BaseNetCoreApi.Services.Interface
{
    public interface IDongBoDanhMucService
    {
        Task<DongBoDanhMucResponse> DongBoDanhMuc(DongBoDanhMucRequest model);
        Task getTokenAsync(APICSDLHelper apiCsdl);
        Task<List<DMHuyenResponseModel>> getDanhSachQuanHuyen(APICSDLHelper apiCsdl, string maTinh, string maHuyen);
        Task<List<DMXaResponseModel>> getDanhSachXaPhuong(APICSDLHelper apiCsdl, string maTinh, string maHuyen, string maXa);
        Task<List<TruongResponseModel>> getDanhSachTruongPhoCapThuocDiaPhuong(APICSDLHelper apiCsdl, string maCapHoc, string maTinh, string maHuyen, string maXa);
        Task<List<TruongResponseModel>> getDanhSachTruongThuocDiaPhuong(APICSDLHelper apiCsdl, string maTinh, string maHuyen, string maXa);
        Task<List<PhongResponseModel>> getDanhSachPhong(APICSDLHelper apiCsdl, string maSo, string maPhong);
        Task<ReturnCode> SyncDanhMucHuyen(APICSDLHelper apiCsdl, string maTinh, string maHuyen);
        Task<ReturnCode> SyncDanhMucXa(APICSDLHelper apiCsdl, string maTinh, string maHuyen, string maXa);
        Task<ReturnCode> SyncDanhMucPhong(APICSDLHelper apiCsdl, string maSGD, string maPGD);
        Task<ReturnCode> SyncHoSoTruong(APICSDLHelper apiCsdl, string maTinh, string maHuyen, string maXa, string capHoc);
    }
}
