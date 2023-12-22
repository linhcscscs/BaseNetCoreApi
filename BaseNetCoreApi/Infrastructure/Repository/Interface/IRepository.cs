using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BaseNetCoreApi.Infrastructure.Repository.Interface
{
    public interface IRepository<TEntity>
    {
        string CacheKeyPattern { get; }
        TEntity? FirstOrDefault();
        TEntity? FirstOrDefault(Func<TEntity, bool> predicate);
        TEntity? GetByMa(string Ma);
        List<TEntity>? GetAll(bool orderByThuTu = false);
        List<TEntity>? GetByListMa(List<string> listMa);
        TEntity? GetById(decimal Id);
        List<TEntity>? GetByListId(List<decimal> listId);
        List<TEntity> GetMulti(Func<TEntity, bool> predicate);
        IQueryable<TEntity> Table { get; }
        void ClearCache();
        void InsertOrUpdate(TEntity entitiy, BulkConfig? bulkConfig = null);
        void InsertOrUpdate(List<TEntity> entities, BulkConfig? bulkConfig = null);
        void Remove(TEntity entity, BulkConfig? bulkConfig = null);
        void Remove(List<TEntity> entities, BulkConfig? bulkConfig = null);
        IQueryable<TEntity> Include(params Expression<Func<TEntity, object>>[] includes);
    }
}
