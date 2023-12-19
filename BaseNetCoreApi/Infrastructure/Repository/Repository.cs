using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq.Expressions;

namespace BaseNetCoreApi.Infrastructure.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        #region Contructor
        protected IUnitOfWork _unitOfWork;
        protected IQiCache _qiCache;
        protected string _cacheKeyPattern;
        protected string? _tableName;
        protected IEntityType? _entityType;
        public Repository(IUnitOfWork unitOfWork, IQiCache qiCache)
        {
            _unitOfWork = unitOfWork;
            _qiCache = qiCache;

            // Bind value
            _cacheKeyPattern = _qiCache.BuildCachedKey(GetType(), typeof(TEntity).Name, _unitOfWork.NamHoc);
            _entityType = _unitOfWork.ReadContext.Model.FindEntityType(typeof(TEntity));
            _tableName = _entityType?.GetTableName();
        }
        #endregion
        #region Method
        private DbSet<TEntity> _dbSetRead
        {
            get => _unitOfWork.ReadContext.Set<TEntity>();
        }
        private DbSet<TEntity> _dbSetWrite
        {
            get => _unitOfWork.WriteContext.Set<TEntity>();
        }
        public string CacheKeyPattern
        {
            get => _cacheKeyPattern;
        }
        public virtual TEntity? FirstOrDefault()
        {
            return _dbSetRead.FirstOrDefault();
        }
        public virtual TEntity? FirstOrDefault(Func<TEntity, bool> predicate)
        {
            var result = _dbSetRead.FirstOrDefault(predicate);
            return result;
        }
        public virtual IQueryable<TEntity> Table
        {
            get => _dbSetRead.AsQueryable();
        }
        public virtual void ClearCache()
        {
            _qiCache.RemoveByFirstName(_cacheKeyPattern);
        }
        public virtual TEntity? GetByMa(string Ma)
        {
            return _qiCache.GetByKey(
                getDataSource: () =>
                {
                    TEntity? result = null;
                    if (_tableName == null)
                    {
                        return result;
                    }
                    string sql = $"SELECT TOP 1 * FROM {_tableName} WHERE MA = '{Ma}'";
                    result = _dbSetRead.FromSqlRaw(sql).FirstOrDefault();
                    return result;
                },
                key: _qiCache.BuildCachedKey(_cacheKeyPattern, "GetByMa", Ma)
                );
        }
        public virtual List<TEntity>? GetByListMa(List<string> listMa)
        {
            return _qiCache.GetByKey(
                getDataSource: () =>
                {
                    List<TEntity>? result = null;
                    if (_tableName == null)
                    {
                        return result;
                    }
                    var lstQuery = UltilHelper.ListToStringQuery(listMa);
                    string sql = $"SELECT * FROM {_tableName} WHERE MA IN '{lstQuery}'";
                    result = _dbSetRead.FromSqlRaw(sql).ToList();
                    return result;
                },
                key: _qiCache.BuildCachedKey(_cacheKeyPattern, "GetByListMa", listMa)
                );
        }
        public virtual TEntity? GetById(decimal Id)
        {
            return _qiCache.GetByKey(
                getDataSource: () =>
                {
                    TEntity? result = null;
                    if (_tableName == null)
                    {
                        return result;
                    }
                    string sql = $"SELECT TOP 1 * FROM {_tableName} WHERE Id = '{Id}'";
                    result = _dbSetRead.FromSqlRaw(sql).FirstOrDefault();
                    return result;
                },
                key: _qiCache.BuildCachedKey(_cacheKeyPattern, "GetById", Id)
                );
        }
        public virtual List<TEntity>? GetByListId(List<decimal> listId)
        {
            return _qiCache.GetByKey(
                    getDataSource: () =>
                    {
                        List<TEntity>? result = null;
                        if (_tableName == null)
                        {
                            return result;
                        }
                        var lstQuery = UltilHelper.ListToStringQuery(listId);
                        string sql = $"SELECT * FROM {_tableName} WHERE Id IN '{lstQuery}'";
                        result = _dbSetRead.FromSqlRaw(sql).ToList();
                        return result;
                    },
                    key: _qiCache.BuildCachedKey(_cacheKeyPattern, "GetByListId", listId)
                    );
        }
        public virtual List<TEntity> GetMulti(Func<TEntity, bool> predicate)
        {
            List<TEntity> result = new List<TEntity>();
            result = _dbSetRead.Where(predicate).ToList();
            return result;
        }
        public virtual void InsertOrUpdate(TEntity entitiy, BulkConfig? bulkConfig = null)
        {
            InsertOrUpdate(new List<TEntity>() { entitiy }, bulkConfig);
        }
        public virtual void InsertOrUpdate(List<TEntity> entities, BulkConfig? bulkConfig = null)
        {
            _unitOfWork.WriteContext.BulkInsertOrUpdate(entities, bulkConfig);
        }
        public virtual void Remove(TEntity entity, BulkConfig? bulkConfig = null)
        {
            Remove(new List<TEntity>() { entity }, bulkConfig);
        }
        public virtual void Remove(List<TEntity> entities, BulkConfig? bulkConfig = null)
        {
            _unitOfWork.WriteContext.BulkDelete(entities, bulkConfig);
        }
        public virtual IQueryable<TEntity> Include(params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = null;
            foreach (var include in includes)
            {
                query = _dbSetRead.Include(include);
            }
            return query == null ? _dbSetRead : query;
        }

        #endregion
    }
}
