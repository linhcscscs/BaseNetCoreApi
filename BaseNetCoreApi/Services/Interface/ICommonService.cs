using BaseNetCoreApi.Models.Dtos;
using BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;
using BaseNetCoreApi.Models.ViewModel;

namespace BaseNetCoreApi.Services.Interface
{
    public interface ICommonService
    {
        PaginationResponse<SoGd> GetSoGd(PaginationRequest<SoGdRequestDto> model);
        PaginationResponse<DMSoGd> GetDMSoGd(PaginationRequest<DMSoGdRequestDto> model);
        SoGd? GetSoGdByMa(string Ma);
        PaginationResponse<PhongGd> GetPhongGd(PaginationRequest<PhongGdRequestDto> model);
        PaginationResponse<DMPhongGd> GetDMPhongGd(PaginationRequest<DMPhongGdRequestDto> model);
        PaginationResponse<Truong> GetTruongPagination(PaginationRequest<TruongRequestDto> model);
        PaginationResponse<DMTruong> GetDMTruong(PaginationRequest<DMTruongRequestDto> model);
        List<DMCapHoc> GetDMCapHoc();
    }
}
