using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Repository;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;

namespace BaseNetCoreApi.Models.Repository
{
    public interface INguoiDungRepository : IRepository<NguoiDung>
    {

    }
    public class NguoiDungRepository : Repository<NguoiDung>, INguoiDungRepository
    {
        public NguoiDungRepository(IUnitOfWork unitOfWork, IQiCache qiCache) : base(unitOfWork, qiCache)
        {
        }
    }
}
