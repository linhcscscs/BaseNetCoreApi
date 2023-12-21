using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Infrastructure.Repository;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.Dtos;
using AutoMapper;

namespace BaseNetCoreApi.Models.Repository
{
    public interface IDmCapHocRepository : IRepository<DmCapHoc>
    {
        List<DMCapHocDto> GetDMCapHocDto();
    }
    public class DmCapHocRepository : Repository<DmCapHoc>, IDmCapHocRepository
    {
        private IMapper _mapper;
        public DmCapHocRepository(IUnitOfWork unitOfWork,
                                  IQiCache qiCache,
                                  IMapper mapper) 
            : base(unitOfWork, qiCache)
        {
            _mapper = mapper;
        }

        public List<DMCapHocDto> GetDMCapHocDto()
        {
            return _mapper.Map<List<DMCapHocDto>>(GetAll(true));
        }
    }
}
