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
using System.Collections.Generic;

namespace BaseNetCoreApi.DomainService
{
    public interface IContextDomainService
    {
        TEntity? GetById<TEntity, TContext>(IContextProvider<TContext> contextProvider, decimal Id, int? ma_nam_hoc = null, double? cacheTime = null)
            where TEntity : class, IId, new()
            where TContext : DbContext;
        public List<TEntity>? GetAll<TEntity, TContext>(IContextProvider<TContext> contextProvider, int? ma_nam_hoc = null, double? cacheTime = null)
            where TEntity : class, new()
            where TContext : DbContext;
        public TEntity? GetByMa<TEntity, TContext>(IContextProvider<TContext> contextProvider, string Ma, string CacheKey, int? ma_nam_hoc = null, double? cacheTime = null)
            where TEntity : class, IMa, new()
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
        public TEntity? GetById<TEntity, TContext>(IContextProvider<TContext> contextProvider, decimal Id, int? ma_nam_hoc = null, double? cacheTime = null)
            where TEntity : class, IId, new()
            where TContext : DbContext
        {
            ma_nam_hoc = ma_nam_hoc ?? ConfigurationHelper.NamHoc;

            string strKeyCache = _qiCache.BuildCachedKey(typeof(TEntity).Name, "GetById", Id);
            TEntity? detail;
            using (var context = contextProvider.GetContext(ma_nam_hoc.Value, false))
            {
                detail = _qiCache.GetByKey(
                            getDataSource: () => (from p in context.Set<TEntity>()
                                                  where p.Id == Id
                                                  select p).FirstOrDefault(),
                            key: strKeyCache,
                            cacheTime: cacheTime ?? CachingTime.CACHING_TIME_DEFAULT_IN_5_MINUTES);
            }
            return detail;
        }

        public List<TEntity>? GetByIds<TEntity, TContext>(IContextProvider<TContext> contextProvider, List<decimal> listId, int? ma_nam_hoc = null, double? cacheTime = null)
    where TEntity : class, IId, new()
    where TContext : DbContext
        {
            ma_nam_hoc = ma_nam_hoc ?? ConfigurationHelper.NamHoc;

            listId.Sort();
            string strKeyCache = _qiCache.BuildCachedKey(typeof(TEntity).Name, "GetById", listId);
            List<TEntity>? detail;
            using (var context = contextProvider.GetContext(ma_nam_hoc.Value, false))
            {
                detail = _qiCache.GetByKey(
                            getDataSource: () => (from p in context.Set<TEntity>()
                                                  where listId.Contains(p.Id)
                                                  select p).ToList(),
                            key: strKeyCache,
                            cacheTime: cacheTime ?? CachingTime.CACHING_TIME_DEFAULT_IN_5_MINUTES);
            }
            return detail;
        }

        public List<TEntity>? GetAll<TEntity, TContext>(IContextProvider<TContext> contextProvider, int? ma_nam_hoc = null, double? cacheTime = null)
            where TEntity : class, new()
            where TContext : DbContext
        {
            ma_nam_hoc = ma_nam_hoc ?? ConfigurationHelper.NamHoc;

            string strKeyCache = _qiCache.BuildCachedKey(typeof(TEntity).Name, "GetAll");
            List<TEntity>? detail;
            using (var context = contextProvider.GetContext(ma_nam_hoc.Value, false))
            {
                detail = _qiCache.GetByKey(
                            getDataSource: () => context.Set<TEntity>().ToList(),
                            key: strKeyCache,
                            cacheTime: cacheTime ?? CachingTime.CACHING_TIME_DEFAULT_IN_5_MINUTES);
            }
            return detail;
        }

        public TEntity? GetByMa<TEntity, TContext>(IContextProvider<TContext> contextProvider, string Ma, string CacheKey, int? ma_nam_hoc = null, double? cacheTime = null)
            where TEntity : class, IMa, new()
            where TContext : DbContext
        {
            ma_nam_hoc = ma_nam_hoc ?? ConfigurationHelper.NamHoc;

            string strKeyCache = _qiCache.BuildCachedKey(CacheKey,typeof(TEntity).Name, "GetByMa", Ma);
            TEntity? detail;
            using (var context = contextProvider.GetContext(ma_nam_hoc.Value, false))
            {
                detail = _qiCache.GetByKey(
                            getDataSource: () => (from p in context.Set<TEntity>()
                                                  where p.Ma == Ma
                                                  select p).FirstOrDefault(),
                            key: strKeyCache,
                            cacheTime: cacheTime ?? CachingTime.CACHING_TIME_DEFAULT_IN_5_MINUTES);
            }
            return detail;
        }

        public TEntity? GetByMas<TEntity, TContext>(IContextProvider<TContext> contextProvider, List<string> listMa, int? ma_nam_hoc = null, double? cacheTime = null)
            where TEntity : class, IMa, new()
            where TContext : DbContext
        {
            ma_nam_hoc = ma_nam_hoc ?? ConfigurationHelper.NamHoc;
            listMa.Sort();
            string strKeyCache = _qiCache.BuildCachedKey(typeof(TEntity).Name, "GetByMas", listMa);
            TEntity? detail;
            using (var context = contextProvider.GetContext(ma_nam_hoc.Value, false))
            {
                detail = _qiCache.GetByKey(
                            getDataSource: () => (from p in context.Set<TEntity>()
                                                  where listMa.Contains(p.Ma)
                                                  select p).FirstOrDefault(),
                            key: strKeyCache,
                            cacheTime: cacheTime ?? CachingTime.CACHING_TIME_DEFAULT_IN_5_MINUTES);
            }
            return detail;
        }
    }
}
