using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Infrastructure.Repository;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.Dtos;
using AutoMapper;

namespace BaseNetCoreApi.Models.Repository
{
    public interface IDmTinhRepository : IRepository<DmTinh>
    {
        List<DMTinhThanhDto> GetDMTinhThanhDto();
    }
    public class DmTinhRepository : Repository<DmTinh>, IDmTinhRepository
    {
        private IMapper _mapper;
        public DmTinhRepository(
            IUnitOfWork unitOfWork,
            IQiCache qiCache,
            IMapper mapper) 
            : base(unitOfWork, qiCache)
        {
            _mapper = mapper;
        }

        public List<DMTinhThanhDto> GetDMTinhThanhDto()
        {
            return _mapper.Map<List<DMTinhThanhDto>>(GetAll(true));
        }
    }
}
