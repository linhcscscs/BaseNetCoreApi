using BaseNetCoreApi.Infrastructure.Models.MongoDb;
using MongoDB.Driver;

namespace BaseNetCoreApi.Infrastructure.MongoDBClient.Interface
{
    public interface IMGCollection<T> where T : MongoBaseClass
    {
        abstract string TABLE_NAME { get; }
        string CacheKeyPattern { get; }
        IQueryable<T> Table {  get; }
        IMongoCollection<T> DataBase { get; }
        void ClearCache();
        bool Save(T model);
        bool Delete(T model);
    }
}
