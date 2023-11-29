using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.ContextProvider;
using BaseNetCoreApi.Infrastructure.ExtendModels.Interface;
using BaseNetCoreApi.Infrastructure.Models.BO_GIAO_DUCEntities;
using BaseNetCoreApi.Models.BO_GIAO_DUCEntities;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Service;
using BaseNetCoreApi.Values;
using Microsoft.EntityFrameworkCore;

namespace BaseNetCoreApi.DomainService
{
    public interface IContextDomainService
    {
        TEntity? GetById<TEntity, TContext>(IContextProvider<TContext> contextProvider, decimal Id, int? ma_nam_hoc = null)
            where TEntity : class, IId, new()
            where TContext : DbContext;
    }
    public class ContextDomainService : IContextDomainService
    {
        private IQiCache _qiCache;
        public ContextDomainService(
            IQiCache qiCache
            )
        {
            _qiCache = qiCache;
        }
        public TEntity? GetById<TEntity, TContext>(IContextProvider<TContext> contextProvider, decimal Id, int? ma_nam_hoc = null)
            where TEntity : class, IId, new()
            where TContext : DbContext
        {
            ma_nam_hoc = ma_nam_hoc ?? ConfigurationHelper.NamHoc;

            string strKeyCache = _qiCache.BuildCachedKey(typeof(TEntity).Name, "GetById", Id);
            TEntity? detail;
            using (var context = contextProvider.GetContext(ma_nam_hoc.Value, false))
            {
                var result = context.Set<TEntity>().FirstOrDefault(q => q.Id == Id);
                detail = _qiCache.GetByKey(
                            getDataSource: () => (from p in context.Set<TEntity>()
                                                  where p.Id == Id
                                                  select p).FirstOrDefault(),
                            key: strKeyCache,
                            cacheTime: CachingTime.CACHING_TIME_DEFAULT_IN_5_MINUTES);
            }
            return detail;
        }
    }
}
