using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Runtime.Serialization;

namespace BaseNetCoreApi.Infrastructure.Models.MongoDb
{
    public class MongoBaseClass
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        [IgnoreDataMember]
        public ObjectId _id { get; set; }
    }
}
