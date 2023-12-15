using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Repository;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;

namespace BaseNetCoreApi.Models.Repository
{
    public interface IMenuRepository : IRepository<Menu>
    {

    }
    public class MenuRepository : Repository<Menu>, IMenuRepository
    {
        public MenuRepository(IUnitOfWork unitOfWork, IQiCache qiCache) : base(unitOfWork, qiCache)
        {
        }
    }
}
