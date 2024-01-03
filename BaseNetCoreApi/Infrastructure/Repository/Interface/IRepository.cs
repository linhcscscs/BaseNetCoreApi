using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using System.Linq.Expressions;
using Z.BulkOperations;

namespace BaseNetCoreApi.Infrastructure.Repository.Interface
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        string CacheKeyPattern { get; }
        TEntity? FirstOrDefault();
        TEntity? FirstOrDefault(Func<TEntity, bool> predicate);
        TEntity? GetByMa(string Ma, string CodeField = "");
        List<TEntity>? GetAll(bool orderByThuTu = false);
        List<TEntity>? GetByListMa(List<string> listMa, string CodeField = "");
        TEntity? GetById(decimal Id, string IdField = "");
        List<TEntity>? GetByListId(List<decimal> listId, string IdField = "");
        IEnumerable<TEntity> GetMulti(Func<TEntity, bool> predicate);
        IQueryable<TEntity> Table { get; }
        void ClearCache();
        void InsertOrUpdate(TEntity entitiy, Action<BulkOperation<TEntity>>? options = null);
        void InsertOrUpdate(List<TEntity> entities, Action<BulkOperation<TEntity>>? options = null);
        void Remove(TEntity entity, Action<BulkOperation<TEntity>>? options = null);
        void Remove(List<TEntity> entities, Action<BulkOperation<TEntity>>? options = null);
        IQueryable<TEntity> Include(params Expression<Func<TEntity, object>>[] includes);
    }
}
