using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Infrastructure.Repository;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.Dtos;
using AutoMapper;

namespace BaseNetCoreApi.Models.Repository
{
    public interface IDmDanTocRepository : IRepository<DmDanToc>
    {
        public List<DmDanTocDto> GetDmDanTocDto();
    }
    public class DmDanTocRepository : Repository<DmDanToc>, IDmDanTocRepository
    {
        private IMapper _mapper;
        public DmDanTocRepository(IUnitOfWork unitOfWork,
                                  IQiCache qiCache,
                                  IMapper mapper) 
            : base(unitOfWork, qiCache)
        {
            _mapper = mapper;
        }
        public List<DmDanTocDto> GetDmDanTocDto()
        {
            return _mapper.Map<List<DmDanTocDto>>(GetAll(true));
        }
    }
}
