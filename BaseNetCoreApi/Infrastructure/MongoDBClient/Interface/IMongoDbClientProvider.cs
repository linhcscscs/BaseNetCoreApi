using MongoDB.Driver;

namespace BaseNetCoreApi.Infrastructure.MongoDBClient.Interface
{
    public interface IMongoDbClientProvider
    {
        MongoClient Client {  get; }
        IMongoDatabase MongoDataBase {  get; }
    }
}
