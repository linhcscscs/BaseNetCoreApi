using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.ContextProvider;
using BaseNetCoreApi.Infrastructure.Models.BO_GIAO_DUCEntities;
using BaseNetCoreApi.Models.BO_GIAO_DUCEntities;
using BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;
using BaseNetCoreApi.Values;
using NguoiDung = BaseNetCoreApi.Models.BO_GIAO_DUCEntities.NguoiDung;

namespace BaseNetCoreApi.Services
{
    public interface INguoiDungService
    {
        NguoiDung GetByNguoiDungBasic(int ma_nam_hoc, decimal id);
    }
    public class NguoiDungService : INguoiDungService
    {
        private IContextProvider<BO_GIAO_DUCEntities> _contextProvider;
        private IQiCache _qiCache;
        public NguoiDungService(IContextProvider<BO_GIAO_DUCEntities> contextProvider,
            IQiCache qiCache)
        {
            _contextProvider = contextProvider;
            _qiCache = qiCache;
        }
        public NguoiDung GetByNguoiDungBasic(int ma_nam_hoc, decimal id)
        {
            string strKeyCache = _qiCache.BuildCachedKey("NGUOI_DUNG", "GetByNguoiDungBasic", id);
            NguoiDung detail = new NguoiDung();
            if (!_qiCache.IsSet(strKeyCache))
            {
                using (var context = _contextProvider.GetContext(ma_nam_hoc, false))
                {
                    var nguoiDung = (from p in context.NguoiDungs
                                     where p.Id == id
                                     select p).FirstOrDefault();

                    if (nguoiDung == null)
                    {
                        return detail;
                    }
                    detail = nguoiDung;
                    _qiCache.Set(strKeyCache, detail!, CachingTime.CACHING_TIME_DEFAULT_IN_5_MINUTES);
                }
            }
            else
            {
                try
                {
                    detail = _qiCache.Get<NguoiDung>(strKeyCache);
                }
                catch
                {
                    _qiCache.Invalidate(strKeyCache);
                }
            }
            return detail;
        }
    }
}
