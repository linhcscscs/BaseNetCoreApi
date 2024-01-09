using AutoMapper;
using BaseNetCoreApi.DomainService.Interface;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.Repository;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Values;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace BaseNetCoreApi.Services
{
    public interface IMenuService
    {
        Menu? GetMenuByPath(string path);
        List<MenuAdminViewModel> UpdateMenus(List<MenuUpdateViewModel> models);
        List<MenuAdminViewModel> DeleteMenu(List<MenuDeleteViewModel> model);
        List<MenuAdminViewModel> InsertMenu(List<MenuAddViewModel> models);
    }
    public class MenuService : IMenuService
    {
        private IMenuRepository _menuRepository;
        private IQiCache _qiCache;
        private IWorkContextService _workContextService;
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public MenuService(
            IMenuRepository menuRepository,
            IQiCache qiCache,
            IWorkContextService workContextService,
            IUnitOfWork unitOfWork,
            IMapper mapper
            )
        {
            _menuRepository = menuRepository;
            _qiCache = qiCache;
            _workContextService = workContextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Menu? GetMenuByPath(string path)
        {
            return _qiCache.GetByKey(
               getDataSource: () => _menuRepository.FirstOrDefault(q => q.Link != null && q.Link.ToUpper().Trim().Replace("~/", "") == path.ToUpper().Trim().Replace("~/", "")),
               key: _qiCache.BuildCachedKey("Menu", "GetMenuByPath", path),
               cacheTime: CachingTime.CACHING_TIME_DEFAULT_IN_24_HOURS,
               isDeepClone: true
               );
        }

        public List<MenuAdminViewModel> UpdateMenus(List<MenuUpdateViewModel> models)
        {
            var lstId = models.Select(s => s.MenuId).ToList();
            var oldMenus = _menuRepository.GetByListId(lstId) ?? new List<Menu>();
            var lstUpdate = new List<Menu>();
            foreach (var oldMenu in oldMenus)
            {
                var model = models.FirstOrDefault(q => q.MenuId == oldMenu.MenuId)!;
                var newMenu = new Menu()
                {
                    MenuId = oldMenu.MenuId,
                    MenuCode = model.MenuCode,
                    MenuNameEg = model.MenuNameEg,
                    MenuName = model.MenuName,
                    Icon = model.Icon,
                    Link = model.Link,
                    TypeHelp = model.TypeHelp,
                    DesHelp = model.DesHelp,
                    LinkYoutube = model.LinkYoutube,
                    Order = model.Order,
                    IsView = model.IsView,
                    Status = model.Status,
                    UpdateBy = _workContextService.NguoiDung.TenDangNhap,
                    UpdateAt = DateTime.Now,
                };
                if (newMenu.Status != oldMenu.Status)
                {
                    newMenu.AuthBy = _workContextService.NguoiDung.TenDangNhap;
                    newMenu.AuthAt = DateTime.Now;
                }
                lstUpdate.Add(newMenu);
            }
            _menuRepository.InsertOrUpdate(lstUpdate);
            _unitOfWork.SaveChanges();
            return _mapper.Map<List<MenuAdminViewModel>>(lstUpdate);
        }
        public List<MenuAdminViewModel> DeleteMenu(List<MenuDeleteViewModel> model)
        {
            var lstId = model.Select(x => x.MenuId).ToList();
            var lstDelete = _menuRepository.GetByListId(lstId) ?? new List<Menu>();
            _menuRepository.Remove(lstDelete);
            _unitOfWork.SaveChanges();
            return _mapper.Map<List<MenuAdminViewModel>>(lstDelete);
        }
        public List<MenuAdminViewModel> InsertMenu(List<MenuAddViewModel> models)
        {
            var lstInsert = new List<Menu>();
            foreach (var model in models)
            {
                var menu = new Menu()
                {
                    MenuCode = model.MenuCode,
                    MenuNameEg = model.MenuNameEg,
                    MenuName = model.MenuName,
                    Icon = model.Icon,
                    Link = model.Link,
                    TypeHelp = model.TypeHelp,
                    DesHelp = model.DesHelp,
                    LinkYoutube = model.LinkYoutube,
                    Order = model.Order,
                    IsView = model.IsView,
                    Status = model.Status,
                    CreateBy = _workContextService.NguoiDung.TenDangNhap,
                    CreateAt = DateTime.Now,
                    AuthBy = _workContextService.NguoiDung.TenDangNhap,
                    AuthAt = DateTime.Now
                };
                lstInsert.Add(menu);
            }
            _menuRepository.InsertOrUpdate(lstInsert);
            _unitOfWork.SaveChanges();
            return _mapper.Map<List<MenuAdminViewModel>>(lstInsert);
        }
    }
}
