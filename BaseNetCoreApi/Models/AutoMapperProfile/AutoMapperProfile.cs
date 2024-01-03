using AutoMapper;
using BaseNetCoreApi.Models.Dtos;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.ViewModel;

namespace BaseNetCoreApi.Models.AutoMapperProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region Danh mục
            CreateMap<DmCapHoc, DMCapHocDto>();
            CreateMap<DmDanToc, DmDanTocDto>();
            CreateMap<DmTinh, DMTinhThanhDto>();
            CreateMap<DmTonGiao, DmTonGiaoDto>();
            CreateMap<DmGioiTinh, DmGioiTinhDto>();
            #endregion

            #region Manager
            CreateMap<Menu, MenuAdminViewModel>();
            #endregion

            #region Common
            CreateMap<Menu, MenuViewModel>();
            #endregion

            #region NhomQuyen
            #endregion
        }
    }
}
