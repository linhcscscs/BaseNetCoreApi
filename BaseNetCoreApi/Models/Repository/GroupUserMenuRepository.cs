using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Infrastructure.Repository;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;

namespace BaseNetCoreApi.Models.Repository
{
    public interface IGroupUserMenuRepository : IRepository<GroupUserMenu>
    {

    }
    public class GroupUserMenuRepository : Repository<GroupUserMenu>, IGroupUserMenuRepository
    {
        public GroupUserMenuRepository(IUnitOfWork unitOfWork, IQiCache qiCache) : base(unitOfWork, qiCache)
        {
        }
    }
}
