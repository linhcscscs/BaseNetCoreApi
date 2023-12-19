using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.MongoDBClient.Interface;
using MongoDB.Driver;

namespace BaseNetCoreApi.Infrastructure.MongoDBClient
{
    public class MongoDbClientProvider : IMongoDbClientProvider
    {
        private MongoClient? _client = null;
        private IMongoDatabase? _dataBase = null;
        public MongoDbClientProvider()
        {
        }
        public MongoClient Client
        {
            get
            {
                if(_client == null)
                {
                    var conn = ConfigurationHelper.GetConnectionStringByName("MongoDBDefaultConnection");
                    _client = new MongoClient(conn);
                }
                return _client;
            }
        }
        public IMongoDatabase MongoDataBase
        {
            get
            {
                if(_dataBase == null)
                {
                    _dataBase = Client.GetDatabase(ConfigurationHelper.MONGODB_NAME);
                }
                return _dataBase;
            }
        }
    }
}
