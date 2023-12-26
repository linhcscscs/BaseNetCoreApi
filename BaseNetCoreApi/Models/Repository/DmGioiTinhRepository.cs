using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Infrastructure.Repository;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.Dtos;
using AutoMapper;
using BaseNetCoreApi.Helper;
using BaseNetCoreApi.DomainService.Interface;
using System.Text.Json;

namespace BaseNetCoreApi.Models.Repository
{
    public interface IDmGioiTinhRepository : IRepository<DmGioiTinh>
    {
        public List<DmGioiTinhDto> GetDmGioiTinhDto();
    }
    public class DmGioiTinhRepository : Repository<DmGioiTinh>, IDmGioiTinhRepository
    {
        private IMapper _mapper;
        public DmGioiTinhRepository(IUnitOfWork unitOfWork,
                                  IQiCache qiCache,
                                  IMapper mapper) 
            : base(unitOfWork, qiCache)
        {
            _mapper = mapper;
        }

        public List<DmGioiTinhDto> GetDmGioiTinhDto()
        {
            return _mapper.Map<List<DmGioiTinhDto>>(GetAll(true));
        }

    }
}
