using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Options;
using NPOI.SS.Formula.Functions;
using System.Collections.Generic;
using System.Linq.Expressions;
using Z.BulkOperations;

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
        protected DbSet<TEntity> _dbSetRead
        {
            get => _unitOfWork.ReadContext.Set<TEntity>();
        }
        protected DbSet<TEntity> _dbSetWrite
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
        public virtual TEntity? GetByMa(string Ma, string CodeField = "")
        {
            return _qiCache.GetByKey(
                getDataSource: () =>
                {
                    TEntity? result = null;
                    if (_tableName == null || Ma == null)
                    {
                        return result;
                    }
                    CodeField = string.IsNullOrEmpty(CodeField) ? "MA" : CodeField;
                    string sql = $"SELECT TOP 1 * FROM {_tableName} WHERE {CodeField} = '{Ma}'";
                    result = _dbSetRead.FromSqlRaw(sql).FirstOrDefault();
                    return result;
                },
                key: _qiCache.BuildCachedKey(_cacheKeyPattern, "GetByMa", Ma)
                );
        }
        public virtual List<TEntity>? GetAll(bool orderByThuTu = false)
        {
            return _qiCache.GetByKey(
                getDataSource: () =>
                {
                    if (!orderByThuTu)
                    {
                        return _dbSetRead.ToList();
                    }
                    else
                    {
                        List<TEntity>? result = null;
                        if (_tableName == null)
                        {
                            return result;
                        }
                        string sql = $"SELECT * FROM {_tableName} ORDER BY THU_TU";
                        result = _dbSetRead.FromSqlRaw(sql).ToList();
                        return result;
                    }
                },
                key: _qiCache.BuildCachedKey(_cacheKeyPattern, "GetAll", orderByThuTu)
                );
        }
        public virtual List<TEntity>? GetByListMa(List<string> listMa, string CodeField = "")
        {
            return _qiCache.GetByKey(
                getDataSource: () =>
                {
                    List<TEntity>? result = null;
                    if (_tableName == null || listMa.Count == 0)
                    {
                        return result;
                    }
                    CodeField = string.IsNullOrEmpty(CodeField) ? "MA" : CodeField;
                    var lstQuery = UltilHelper.ListToStringQuery(listMa);
                    string sql = $"SELECT * FROM {_tableName} WHERE {CodeField} IN '{lstQuery}'";
                    result = _dbSetRead.FromSqlRaw(sql).ToList();
                    return result;
                },
                key: _qiCache.BuildCachedKey(_cacheKeyPattern, "GetByListMa", listMa)
                );
        }
        public virtual TEntity? GetById(decimal Id, string IdField = "")
        {
            return _qiCache.GetByKey(
                getDataSource: () =>
                {
                    TEntity? result = null;
                    if (_tableName == null)
                    {
                        return result;
                    }
                    IdField = string.IsNullOrEmpty(IdField) ? "Id" : IdField;
                    string sql = $"SELECT TOP 1 * FROM {_tableName} WHERE {IdField} = '{Id}'";
                    result = _dbSetRead.FromSqlRaw(sql).FirstOrDefault();
                    return result;
                },
                key: _qiCache.BuildCachedKey(_cacheKeyPattern, "GetById", Id)
                );
        }
        public virtual List<TEntity>? GetByListId(List<decimal> listId, string IdField = "")
        {
            return _qiCache.GetByKey(
                    getDataSource: () =>
                    {
                        List<TEntity>? result = null;
                        if (_tableName == null)
                        {
                            return result;
                        }
                        IdField = string.IsNullOrEmpty(IdField) ? "Id" : IdField;
                        var lstQuery = UltilHelper.ListToStringQuery(listId);
                        string sql = $"SELECT * FROM {_tableName} WHERE {IdField} IN '{lstQuery}'";
                        result = _dbSetRead.FromSqlRaw(sql).ToList();
                        return result;
                    },
                    key: _qiCache.BuildCachedKey(_cacheKeyPattern, "GetByListId", listId)
                    );
        }
        public virtual IEnumerable<TEntity> GetMulti(Func<TEntity, bool> predicate)
        {
            return _dbSetRead.Where(predicate);
        }
        public virtual void InsertOrUpdate(TEntity entitiy, Action<BulkOperation<TEntity>>? options = null)
        {
            InsertOrUpdate(new List<TEntity>() { entitiy }, options);
        }
        public virtual void InsertOrUpdate(List<TEntity> entities, Action<BulkOperation<TEntity>>? options = null)
        {
            _unitOfWork.WriteContext.BulkMerge(entities, options);
            ClearCache();
        }
        public virtual void Remove(TEntity entity, Action<BulkOperation<TEntity>>? options = null)
        {
            Remove(new List<TEntity>() { entity }, options);
        }
        public virtual void Remove(List<TEntity> entities, Action<BulkOperation<TEntity>>? options = null)
        {
            _unitOfWork.WriteContext.BulkDelete(entities, options);
            ClearCache();
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
