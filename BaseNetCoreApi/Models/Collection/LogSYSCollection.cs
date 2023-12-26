
using Amazon.Runtime.Internal.Util;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Models.MongoDb;
using BaseNetCoreApi.Infrastructure.MongoDBClient;
using BaseNetCoreApi.Infrastructure.MongoDBClient.Interface;
using BaseNetCoreApi.Models.Collection.Interface;
using MongoDB.Driver;

namespace BaseNetCoreApi.Models.Collection
{
    public class LogSYSCollection : MGCollection<LogSYSModel>, ILogSYSCollection
    {
        public LogSYSCollection(IMongoDbClientProvider mongoDbClientProvider, IQiCache qiCache) : base(mongoDbClientProvider, qiCache)
        {
        }
        public override string TABLE_NAME => "LogSYS";
    }
}
