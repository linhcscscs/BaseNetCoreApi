using BaseNetCoreApi.Infrastructure.Models.MongoDb;
using BaseNetCoreApi.Infrastructure.MongoDBClient.Interface;

namespace BaseNetCoreApi.Models.Collection.Interface
{
    public interface ILogSYSCollection : IMGCollection<LogSYSModel>
    {
        public void SaveLog(string hanh_dong, string ghi_chu, string ten_bang, string ma_tinh, string ma_huyen, string ma_xa, int ma_nam_hoc, string nguoi, string ip, string url, string user_agent);
    }
}
