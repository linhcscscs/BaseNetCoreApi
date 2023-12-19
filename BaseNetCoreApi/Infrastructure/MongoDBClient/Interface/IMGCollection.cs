using MongoDB.Driver;

namespace BaseNetCoreApi.Infrastructure.MongoDBClient.Interface
{
    public interface IMGCollection<T> where T : class
    {
        abstract string TABLE_NAME { get; }
        string CacheKeyPattern { get; }
        IQueryable<T> Table {  get; }
        IMongoCollection<T> DataBase { get; }
        void ClearCache();
        bool Save(T model);
    }
}
