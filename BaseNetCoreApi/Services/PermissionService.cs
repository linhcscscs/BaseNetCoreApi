using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.CacheProvider.CacheKey;
using BaseNetCoreApi.Infrastructure.ContextProvider;
using BaseNetCoreApi.Infrastructure.Models.BO_GIAO_DUCEntities;
using BaseNetCoreApi.Models.BO_GIAO_DUCEntities;
using BaseNetCoreApi.Models.Entities;
using BaseNetCoreApi.Service;
using BaseNetCoreApi.Values;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using System.Linq;

namespace BaseNetCoreApi.Services
{
    public interface IPermissionService
    {
        public Menu? GetMenuByPath(string path);
        public List<QuyenNguoiDung> GetQuyenNguoiDungByNguoiDung(decimal nguoiDungId);
        public List<GroupUserMenu> GetGroupUserMenuByNguoiDungByPath(decimal nguoiDungId, string path);
        public List<GroupUserMenu> GetGroupUserMenuByNguoiDungByPathByTruongBySo(decimal nguoiDungId, string path, string ma_truong, string ma_so_gd);
        public List<GroupUserMenu> GetQuyenNguoiDungByNguoiDungByTruongBySo(decimal nguoiDungId, string ma_truong, string ma_so_gd);
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
        public Menu? GetMenuByPath(string path)
        {
            using (var context = _contextProvider.GetContext(_workContextService.MA_NAM_HOC, false))
            {
                if (path[0] != '~')
                {
                    path = "~" + path;
                }
                return _qiCache.GetByKey(
                   getDataSource: () => context.Menus.FirstOrDefault(q => q.Link == path),
                   key: _qiCache.BuildCachedKey("Menu", "GetMenuByPath", path),
                   cacheTime: CachingTime.CACHING_TIME_DEFAULT_IN_24_HOURS,
                   isDeepClone: true
                   );
            }
        }
        public List<QuyenNguoiDung> GetQuyenNguoiDungByNguoiDung(decimal nguoiDungId)
        {
            using (var context = _contextProvider.GetContext(_workContextService.MA_NAM_HOC, false))
            {
                return _qiCache.GetByKey(
                   getDataSource: () => context.QuyenNguoiDungs.Where(q => q.IdNguoiDung == nguoiDungId).ToList(),
                   key: _qiCache.BuildCachedKey(CacheKey.QUYEN, "GetQuyenNguoiDungByNguoiDung", nguoiDungId),
                   cacheTime: CachingTime.CACHING_TIME_DEFAULT_IN_5_MINUTES
                   );
            }
        }

        public List<GroupUserMenu> GetQuyenNguoiDungByNguoiDungByTruongBySo(decimal nguoiDungId, string ma_truong, string ma_so_gd)
        {
            using (var context = _contextProvider.GetContext(_workContextService.MA_NAM_HOC, false))
            {
                var quyenNguoiDungIds = GetQuyenNguoiDungByNguoiDung(nguoiDungId)
                    .Where(q =>  q.MaTruong == ma_truong && q.MaSoGd == ma_so_gd)
                    .Select(s => s.IdNhomQuyen).ToList();
                return _qiCache.GetByKey(
                   getDataSource: () => context.GroupUserMenus
                            .Include(i => i.Menu)
                            .Where(q => quyenNguoiDungIds.Contains(q.GroupUserId))
                            .ToList(),
                   key: _qiCache.BuildCachedKey(CacheKey.QUYEN, "GetQuyenNguoiDungByNguoiDungByTruongBySo", nguoiDungId, ma_truong, ma_so_gd),
                   cacheTime: CachingTime.CACHING_TIME_DEFAULT_IN_5_MINUTES
                   );
            }
        }

        public List<GroupUserMenu> GetGroupUserMenuByNguoiDungByPath(decimal nguoiDungId, string path)
        {
            using (var context = _contextProvider.GetContext(_workContextService.MA_NAM_HOC, false))
            {
                var result = new List<GroupUserMenu>();
                var menu = GetMenuByPath(path);
                if (menu == null)
                {
                    return result;
                }

                var quyenNguoiDungIds = GetQuyenNguoiDungByNguoiDung(nguoiDungId).Select(s => s.IdNhomQuyen).ToList();

                return _qiCache.GetByKey(
                   getDataSource: () => context.GroupUserMenus
                            .Where(q => quyenNguoiDungIds.Contains(q.GroupUserId))
                            .ToList(),
                   key: _qiCache.BuildCachedKey(CacheKey.QUYEN, "GetGroupUserMenuByNguoiDungByPath", nguoiDungId, path),
                   cacheTime: CachingTime.CACHING_TIME_DEFAULT_IN_5_MINUTES
                   );
            }
        }
        public List<GroupUserMenu> GetGroupUserMenuByNguoiDungByPathByTruongBySo(decimal nguoiDungId, string path, string ma_truong, string ma_so_gd)
        {
            using (var context = _contextProvider.GetContext(_workContextService.MA_NAM_HOC, false))
            {
                var result = new List<GroupUserMenu>();
                var menu = GetMenuByPath(path);

                if (menu == null)
                {
                    return result;
                }

                var quyenNguoiDungIds = GetQuyenNguoiDungByNguoiDung(nguoiDungId).Where(q => q.MaTruong == ma_truong && q.MaSoGd == ma_so_gd).Select(s => s.IdNhomQuyen).ToList();

                return _qiCache.GetByKey(
                   getDataSource: () => context.GroupUserMenus
                            .Where(q => quyenNguoiDungIds.Contains(q.GroupUserId))
                            .ToList(),
                   key: _qiCache.BuildCachedKey(CacheKey.QUYEN, "GetGroupUserMenuByNguoiDungByPathByTruongBySo", nguoiDungId, path, ma_truong, ma_so_gd),
                   cacheTime: CachingTime.CACHING_TIME_DEFAULT_IN_5_MINUTES
                   );
            }
        }
        #endregion
    }
}
