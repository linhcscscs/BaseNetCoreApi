using AutoMapper;
using BaseNetCoreApi.Models.Dtos;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;

namespace BaseNetCoreApi.Models.AutoMapperProfile
{
    public partial class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap();
        }
    }
}
