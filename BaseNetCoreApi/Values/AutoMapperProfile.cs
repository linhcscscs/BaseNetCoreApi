using AutoMapper;
using BaseNetCoreApi.Models.Dtos;

namespace BaseNetCoreApi.Values
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<DMTruongRequestDto,TruongRequestDto>();
        }
    }
}
