using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Infrastructure.Repository;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.Entities;
using BaseNetCoreApi.DomainService.Interface;
using Z.BulkOperations;

namespace BaseNetCoreApi.Models.Repository
{
    public interface IGroupUserMenuRepository : IRepository<GroupUserMenu>
    {
        GroupUserMenu? GetById(long Id);
        List<GroupUserMenuEntity> getQuyenByGroupUserID(long Id);
    }
    public class GroupUserMenuRepository : Repository<GroupUserMenu>, IGroupUserMenuRepository
    {
        private IWorkContextService _workContextService;
        public GroupUserMenuRepository(
            IUnitOfWork unitOfWork,
            IQiCache qiCache,
            IWorkContextService workContextService) : base(unitOfWork, qiCache)
        {
            _workContextService = workContextService;
        }
        public GroupUserMenu? GetById(long Id)
        {
            return base.GetById(Id, "GroupUserMenuId");
        }
        public List<GroupUserMenuEntity> getQuyenByGroupUserID(long Id)
        {
            List<GroupUserMenuEntity> data = new List<GroupUserMenuEntity>();
            return _qiCache.GetByKey(
                getDataSource: () =>
                {
                    string sql = @$"select m.MenuID,
                                        m.ParentID,
                                        m.MenuCode,
                                        m.MenuName,
										m.Link,
                                        gum.GroupUserMenuID,
                                        gum.GroupUserID,
                                        ISNULL(gum.isView, 0) AS IsView,
                                        ISNULL(gum.IsAdd, 0) AS IsAdd,
                                        ISNULL(gum.IsEdit,0) AS IsEdit,
                                        ISNULL(gum.IsDelete,0) AS IsDelete,
                                        ISNULL(gum.IsUpload,0) AS IsUpload,
                                        ISNULL(gum.IsAuth,0) AS IsAuth
                                        from MENU m
                                        left join GroupUserMenu gum on m.MenuID=gum.MenuID and gum.GroupUserID={Id}
                                        order by m.[Order]";
                    return _unitOfWork.SqlQuery<GroupUserMenuEntity>(sql).ToList();
                },
                key: _qiCache.BuildCachedKey(CacheKeyPattern, "Menu", "getQuyenByGroupUserID", Id),
                cacheTime: 300000
                );
        }

        public override void InsertOrUpdate(List<GroupUserMenu> entities, Action<BulkOperation<GroupUserMenu>>? options = null)
        {
            foreach (var entity in entities)
            {
                if (entity.GroupUserMenuId <= 0)
                {
                    entity.CreateAt = DateTime.Now;
                    entity.CreateBy = _workContextService.NguoiDung.TenDangNhap;
                }
                else
                {
                    entity.UpdateAt = DateTime.Now;
                    entity.UpdateBy = _workContextService.NguoiDung.TenDangNhap;
                }
            }

            base.InsertOrUpdate(entities, options =>
            {
                options.BatchSize = 100;
                options.ColumnPrimaryKeyExpression = entity => new
                {
                    entity.MenuId,
                    entity.GroupUserId
                };
            });
        }
    }
}
