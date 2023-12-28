
using Amazon.Runtime.Internal.Util;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Models.MongoDb;
using BaseNetCoreApi.Infrastructure.MongoDBClient;
using BaseNetCoreApi.Infrastructure.MongoDBClient.Interface;
using BaseNetCoreApi.Models.Collection.Interface;
using BaseNetCoreApi.Models.Dtos;
using BaseNetCoreApi.Models.Model;
using BaseNetCoreApi.Values;
using MongoDB.Driver;
using System.Text.Json;

namespace BaseNetCoreApi.Models.Collection
{
    public class LogSYSCollection : MGCollection<LogSYSModel>, ILogSYSCollection
    {
        public LogSYSCollection(IMongoDbClientProvider mongoDbClientProvider, IQiCache qiCache) : base(mongoDbClientProvider, qiCache)
        {
        }
        public override string TABLE_NAME => "LogSYS";

        public PaginationResponse<LogSYSModel> GetLog(PaginationRequest<GetLogSysFilter> model)
        {
            return _qiCache.GetByKey(
                getDataSource: () =>
                {
                    var queryable =  (from obj in Table
                            where
                            (string.IsNullOrEmpty(model.Filter.MaTinh) || obj.MA_TINH == model.Filter.MaTinh)
                           && (string.IsNullOrEmpty(model.Filter.MaHuyen) || obj.MA_HUYEN == model.Filter.MaHuyen)
                           && (string.IsNullOrEmpty(model.Filter.MaXa) || obj.MA_XA == model.Filter.MaXa)
                           && (string.IsNullOrEmpty(model.Filter.TenBang) || obj.TEN_BANG.ToLower().Contains(model.Filter.TenBang.ToLower()))
                           && (string.IsNullOrEmpty(model.Filter.HanhDong) || obj.HANH_DONG.ToLower().Contains(model.Filter.HanhDong.ToLower()))
                           && (model.Filter.FromDate == null || obj.NGAY_TAO >= model.Filter.FromDate)
                           && (model.Filter.ToDate == null || obj.NGAY_TAO <= model.Filter.ToDate.Value.AddDays(1))

                            orderby obj.MA_TINH, obj.MA_XA, obj.NGAY_TAO descending

                            select new LogSYSModel
                            {
                                _id = obj._id,
                                MA_NAM_HOC = obj.MA_NAM_HOC,
                                MA_TINH = obj.MA_TINH,
                                MA_HUYEN = obj.MA_HUYEN,
                                MA_XA = obj.MA_XA,
                                TEN_BANG = obj.TEN_BANG,
                                GHI_CHU = obj.GHI_CHU,
                                KEY_VAL = obj.KEY_VAL,
                                NGUOI_TAO = obj.NGUOI_TAO,
                                NGAY_TAO = obj.NGAY_TAO,
                                HANH_DONG = obj.HANH_DONG,
                                IP = obj.IP,
                                URL = obj.URL,
                                USER_AGENT = obj.USER_AGENT,
                            });
                    var reqModel = new PaginationModel<LogSYSModel>()
                    {
                        PageIndex = model.PageIndex,
                        PageSize = model.PageSize,
                        Queryable = queryable,
                    };
                    return new PaginationResponse<LogSYSModel>(reqModel);
                },
                key: _qiCache.BuildCachedKey(CacheKeyPattern, "GetLog", JsonSerializer.Serialize(model)),
                cacheTime: CachingTime.CACHING_TIME_DEFAULT_IN_1_MINUTES
                );
        }
    }
}
