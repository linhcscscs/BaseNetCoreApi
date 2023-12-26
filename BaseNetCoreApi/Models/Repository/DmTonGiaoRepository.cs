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
    public interface IDmTonGiaoRepository : IRepository<DmTonGiao>
    {
        public List<DmTonGiaoDto> GetDmTonGiaoDtos();
    }
    public class DmTonGiaoRepository : Repository<DmTonGiao>, IDmTonGiaoRepository
    {
        private IMapper _mapper;
        public DmTonGiaoRepository(IUnitOfWork unitOfWork,
                                  IQiCache qiCache,
                                  IMapper mapper) 
            : base(unitOfWork, qiCache)
        {
            _mapper = mapper;
        }

        public List<DmTonGiaoDto> GetDmTonGiaoDtos()
        {
            return _mapper.Map<List<DmTonGiaoDto>>(GetAll(true));
        }

    }
}
