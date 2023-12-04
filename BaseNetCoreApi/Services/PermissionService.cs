using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.ContextProvider;
using BaseNetCoreApi.Infrastructure.Models.BO_GIAO_DUCEntities;
using BaseNetCoreApi.Models.BO_GIAO_DUCEntities;
using BaseNetCoreApi.Models.Entities;
using BaseNetCoreApi.Service;
using BaseNetCoreApi.Values;
using System.Linq;
using static BaseNetCoreApi.Values.ScopePermission;

namespace BaseNetCoreApi.Services
{
    public interface IPermissionService
    {
        List<PermissonEntity> GetPermissonEntities();
        List<NhomQuyen> GetNhomQuyen(string ma_so_gd = "", string ma_truong = "");
        public List<NhomQuyenNguoiDung> GetNhomQuyenNguoiDung(string ma_so_gd = "", string ma_truong = "", decimal? nguoiDungId = null, decimal? nhomQuyenId = null);
        public List<PermissonEntity> GetPermissonGroupByUserAndBranch(string ma_so_gd, string ma_truong, decimal nguoiDungId);
        public List<PermissonEntity> GetPermissonGroupByUserAndBranch(NguoiDung nguoiDung);
    }
    public class PermissionService : IPermissionService
    {
        #region Contructor
        private IBoGiaoDucContextProvider _contextProvider;
        private IWorkContextService _workContextService;
        private IQiCache _qiCache;
        public PermissionService(IBoGiaoDucContextProvider contextProvider, IWorkContextService workContextService, IQiCache qiCache)
        {
            _contextProvider = contextProvider;
            _workContextService = workContextService;
            _qiCache = qiCache;
        }
        #endregion

        #region Method
        public List<PermissonEntity> GetPermissonEntities()
        {
            var cacheKey = _qiCache.BuildCachedKey("GetPermissonEntities");
            return _qiCache.GetByKey<List<PermissonEntity>>(
                getDataSource: () => Enum.GetValues(typeof(EScopePermission)).Cast<EScopePermission>().Select(s => new PermissonEntity(s)).ToList(),
                key: cacheKey,
                cacheTime: CachingTime.CACHING_TIME_DEFAULT_IN_24_HOURS,
                isDeepClone: true
                );
        }

        public List<NhomQuyen> GetNhomQuyen(string ma_so_gd = "", string ma_truong = "")
        {
            var result = new List<NhomQuyen>();

            using (var context = _contextProvider.GetContext(_workContextService.MA_NAM_HOC, false))
            {
                var queryable = context.NhomQuyens.AsQueryable();
                if (string.IsNullOrEmpty(ma_so_gd))
                {
                    queryable = queryable.Where(q => q.MaSoGd == ma_so_gd);
                }
                if (string.IsNullOrEmpty(ma_truong))
                {
                    queryable = queryable.Where(q => q.MaSoGd == ma_truong);
                }

                var cacheKey = _qiCache.BuildCachedKey("GetNhomQuyen", ma_truong, ma_so_gd);

                result = _qiCache.GetByKey<List<NhomQuyen>>(
                    getDataSource: () => queryable.ToList(),
                    key: cacheKey,
                    cacheTime: CachingTime.CACHING_TIME_DEFAULT_IN_24_HOURS,
                    isDeepClone: true
                    );

            };
            return result;
        }

        public List<NhomQuyenNguoiDung> GetNhomQuyenNguoiDung(string ma_so_gd = "", string ma_truong = "", decimal? nguoiDungId = null, decimal? nhomQuyenId = null)
        {
            var result = new List<NhomQuyenNguoiDung>();
            var context = _contextProvider.GetContext(_workContextService.MA_NAM_HOC, false);
            var queryable = context.NhomQuyenNguoiDungs.AsQueryable();
            if (nguoiDungId != null)
            {
                queryable = queryable.Where(q => q.NguoiDungId == nguoiDungId).AsQueryable();
            }
            if (nhomQuyenId != null)
            {
                queryable = queryable.Where(q => q.NhomQuyenId == nhomQuyenId).AsQueryable();
            }
            var cacheKey = _qiCache.BuildCachedKey("GetNhomQuyenNguoiDungByNguoiDung", nguoiDungId?.ToString() ?? "", nhomQuyenId?.ToString() ?? "");

            result = _qiCache.GetByKey<List<NhomQuyenNguoiDung>>(
                getDataSource: () => queryable.ToList(),
                key: cacheKey,
                cacheTime: CachingTime.CACHING_TIME_DEFAULT_IN_24_HOURS,
                isDeepClone: true
                );
            return result;
        }

        public List<PermissonEntity> GetPermissonGroupByUserAndBranch(string ma_so_gd, string ma_truong, decimal nguoiDungId)
        {
            List<PermissonEntity>? result;
            using (var context = _contextProvider.GetContext(_workContextService.MA_NAM_HOC, false))
            {
                var lstIdNhomQuyenId = GetNhomQuyenNguoiDung(nguoiDungId: nguoiDungId,
                                                        ma_truong: ma_truong,
                                                        ma_so_gd: ma_so_gd).Select(s => s.NhomQuyenId);
                var permissions = GetNhomQuyen(ma_so_gd, ma_truong).Where(q => lstIdNhomQuyenId.Contains(q.Id)).Select(s => s.DsMaQuyen);
                var lstPermissionCode = permissions.Select(s => UltilHelper.ConvertStringToListString(s ?? ""))
                       .SelectMany(lst => lst).Distinct().ToList();
                result = GetPermissonEntities().Where(q => lstPermissionCode.Contains(q.Code)).ToList();
            }
            return result ?? new List<PermissonEntity>();
        }

        public bool HasPermission(string ma_so_gd, string ma_truong, decimal nguoiDungId, EScopePermission permission)
        {
            return GetPermissonGroupByUserAndBranch(ma_so_gd, ma_truong, nguoiDungId).Any(a => a.ScopePermission == permission);
        }

        public List<PermissonEntity> GetPermissonGroupByUserAndBranch(NguoiDung nguoiDung)
        {
            List<PermissonEntity>? result ;
            if (nguoiDung.IsRoot == 1)
            {
                result = GetPermissonEntities();
            }
            else
            {
                result = GetPermissonGroupByUserAndBranch(nguoiDung.MaSoGd, nguoiDung.MaTruong, nguoiDung.Id);
            }
            return result ?? new List<PermissonEntity>();
        }
        #endregion
    }
}
