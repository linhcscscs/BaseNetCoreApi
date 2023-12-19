using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.MongoDBClient.Interface;
using MongoDB.Driver;

namespace BaseNetCoreApi.Infrastructure.MongoDBClient
{
    public abstract class MGCollection<T> : IMGCollection<T> where T : class
    {
        protected IMongoDbClientProvider _mongoDbClientProvider;
        protected IQiCache _qiCache;
        public MGCollection(
            IMongoDbClientProvider mongoDbClientProvider,
            IQiCache qiCache
            )
        {
            _mongoDbClientProvider = mongoDbClientProvider;
            _qiCache = qiCache;

            CacheKeyPattern = _qiCache.BuildCachedKey(GetType(),typeof(T), TABLE_NAME);
        }
        public abstract string TABLE_NAME { get; }
        public string CacheKeyPattern { get; private set; }
        public IMongoCollection<T> DataBase
        {
            get => _mongoDbClientProvider.MongoDataBase.GetCollection<T>(TABLE_NAME);
        }
        public IQueryable<T> Table => DataBase.AsQueryable();
        public virtual void ClearCache()
        {
            _qiCache.RemoveByFirstName(CacheKeyPattern);
        }
        public virtual bool Save(T model)
        {
            try
            {
                Thread thread = new Thread(() =>
                {
                    DataBase.InsertOne(model);
                });
                thread.Start();
                ClearCache();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}

