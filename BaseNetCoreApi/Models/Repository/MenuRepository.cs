using AutoMapper;
using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Repository;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.ViewModel;
using DocumentFormat.OpenXml.Office2010.Excel;
using MathNet.Numerics.Statistics.Mcmc;
using Microsoft.EntityFrameworkCore;

namespace BaseNetCoreApi.Models.Repository
{
    public interface IMenuRepository : IRepository<Menu>
    {
        List<MenuAdminViewModel> GetMenuAdminViewModels();
        List<Menu> GetByListId(List<long> listId);
        Menu? GetById(long Id);
        List<MenuViewModel> GetMenuViewModels();
    }
    public class MenuRepository : Repository<Menu>, IMenuRepository
    {
        private IMapper _mapper;
        public MenuRepository(IUnitOfWork unitOfWork, IQiCache qiCache, IMapper mapper) : base(unitOfWork, qiCache)
        {
            _mapper = mapper;
        }
        public List<MenuAdminViewModel> GetMenuAdminViewModels()
        {
            return _mapper.Map<List<MenuAdminViewModel>>(GetAll());
        }
        public List<MenuViewModel> GetMenuViewModels()
        {
            return _mapper.Map<List<MenuViewModel>>(GetAll());
        }

        public Menu? GetById(long Id)
        {
            return _qiCache.GetByKey(
                getDataSource: () =>
                {
                    var result = _dbSetRead.First(q => q.MenuId == Id);
                    return result;
                },
                key: _qiCache.BuildCachedKey(_cacheKeyPattern, "GetById", Id)
                );
        }
        public List<Menu> GetByListId(List<long> listId)
        {
            return _qiCache.GetByKey(
                    getDataSource: () =>
                    {
                        var result = _dbSetRead.Where(q => listId.Contains(q.MenuId)).ToList();
                        return result;
                    },
                    key: _qiCache.BuildCachedKey(_cacheKeyPattern, "GetByListId", listId)
                    );
        }
    }
}
