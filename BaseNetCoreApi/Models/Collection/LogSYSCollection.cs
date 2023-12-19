
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

        public void SaveLog(string hanh_dong, string ghi_chu, string ten_bang, string ma_tinh, string ma_huyen, string ma_xa, int ma_nam_hoc, string nguoi, string ip, string url, string user_agent)
        {
            try
            {
                LogSYSModel itemLog = new LogSYSModel();
                itemLog._id = MongoDB.Bson.ObjectId.GenerateNewId();
                itemLog.MA_NAM_HOC = ma_nam_hoc;
                itemLog.MA_TINH = ma_tinh;
                itemLog.MA_HUYEN = ma_huyen;
                itemLog.MA_XA = ma_xa;
                itemLog.NGAY_TAO = DateTime.Now;
                itemLog.HANH_DONG = hanh_dong;
                itemLog.TEN_BANG = ten_bang;
                itemLog.GHI_CHU = ghi_chu;
                itemLog.NGUOI_TAO = nguoi;
                itemLog.IP = ip;
                itemLog.URL = url;
                itemLog.USER_AGENT = user_agent;
                Save(itemLog);
            }
            catch { }
        }
    }
}
