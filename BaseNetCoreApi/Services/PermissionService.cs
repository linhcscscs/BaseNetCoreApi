using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.CacheProvider.CacheKey;
using BaseNetCoreApi.Infrastructure.ContextProvider.Interface;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.Repository;
using BaseNetCoreApi.Service;
using BaseNetCoreApi.Services.Interface;
using BaseNetCoreApi.Values;

namespace BaseNetCoreApi.Services
{
    public class PermissionService : IPermissionService
    {
        #region Contructor
        private IPhoCapGDContextProvider _contextProvider;
        private IWorkContextService _workContextService;
        private IQiCache _qiCache;
        private IMenuRepository _menuRepository;
        private INguoiDungRepository _nguoiDungRepository;
        private IGroupUserRepository _groupUserRepository;
        private IGroupUserMenuRepository _groupUserMenuRepository;
        public PermissionService(IPhoCapGDContextProvider contextProvider,
            IWorkContextService workContextService,
            IQiCache qiCache,
            IMenuRepository menuRepository,
            INguoiDungRepository nguoiDungRepository,
            IGroupUserRepository groupUserRepository,
            IGroupUserMenuRepository groupUserMenuRepository)
        {
            _contextProvider = contextProvider;
            _workContextService = workContextService;
            _qiCache = qiCache;
            _menuRepository = menuRepository;
            _nguoiDungRepository = nguoiDungRepository;
            _groupUserRepository = groupUserRepository;
            _groupUserMenuRepository = groupUserMenuRepository;
        }
        #endregion

        #region Method
        public Menu? GetMenuByPath(string path)
        {
            if (path[0] != '~')
            {
                path = "~" + path;
            }
            return _qiCache.GetByKey(
               getDataSource: () => _menuRepository.FirstOrDefault(q => q.Link == path),
               key: _qiCache.BuildCachedKey("Menu", "GetMenuByPath", path),
               cacheTime: CachingTime.CACHING_TIME_DEFAULT_IN_24_HOURS,
               isDeepClone: true
               );
        }
        public GroupUser? GetGroupUserByNguoiDung(decimal nguoiDungId)
        {
            var nguoiDung = _nguoiDungRepository.FirstOrDefault(q => q.Id == nguoiDungId);
            if (nguoiDung == null)
            {
                return new GroupUser();
            }
            return _qiCache.GetByKey(
               getDataSource: () => _groupUserRepository.FirstOrDefault(q => q.GroupUserId == nguoiDung.GroupUserId),
               key: _qiCache.BuildCachedKey(CacheKey.QUYEN, "GetGroupUserByNguoiDung", nguoiDungId),
               cacheTime: CachingTime.CACHING_TIME_DEFAULT_IN_5_MINUTES
               );
        }

        public List<GroupUserMenu> GetGroupUserMenuByNguoiDung(decimal nguoiDungId)
        {
            using (var context = _contextProvider.GetContext(_workContextService.MA_NAM_HOC, false))
            {
                var groupUser = GetGroupUserByNguoiDung(nguoiDungId);
                if (groupUser == null)
                {
                    return new List<GroupUserMenu>();
                }
                return _qiCache.GetByKey(
                   getDataSource: () => _groupUserMenuRepository
                            .Include(i => i.Menu)
                            .Where(q => q.GroupUserId == groupUser.GroupUserId)
                            .ToList(),
                   key: _qiCache.BuildCachedKey(CacheKey.QUYEN, "GetGroupUserMenuByNguoiDung", nguoiDungId),
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

                var lstGroupUser = GetGroupUserMenuByNguoiDung(nguoiDungId);

                return _qiCache.GetByKey(
                   getDataSource: () => lstGroupUser
                            .Where(q => menu.MenuId == q.MenuId).ToList(),
                   key: _qiCache.BuildCachedKey(CacheKey.QUYEN, "GetGroupUserMenuByNguoiDungByPath", nguoiDungId, path),
                   cacheTime: CachingTime.CACHING_TIME_DEFAULT_IN_5_MINUTES
                   );
            }
        }
        #endregion
    }
}
