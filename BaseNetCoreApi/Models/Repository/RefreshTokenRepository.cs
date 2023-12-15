using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Infrastructure.Repository;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;

namespace BaseNetCoreApi.Models.Repository
{
    public interface IRefreshTokenRepository : IRepository<RefreshToken>
    {

    }
    public class RefreshTokenRepository : Repository<RefreshToken>, IRefreshTokenRepository
    {
        public RefreshTokenRepository(IUnitOfWork unitOfWork, IQiCache qiCache) : base(unitOfWork, qiCache)
        {
        }
    }
}
