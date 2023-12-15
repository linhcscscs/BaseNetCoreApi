using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Repository;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;

namespace BaseNetCoreApi.Models.Repository
{
    public interface IGroupUserRepository : IRepository<GroupUser>
    {

    }
    public class GroupUserRepository : Repository<GroupUser>, IGroupUserRepository
    {
        public GroupUserRepository(IUnitOfWork unitOfWork, IQiCache qiCache) : base(unitOfWork, qiCache)
        {
        }
    }
}
