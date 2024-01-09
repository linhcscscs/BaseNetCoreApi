using AutoMapper;
using BaseNetCoreApi.DomainService.Interface;
using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Repository;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Values;
using DocumentFormat.OpenXml.InkML;
using MathNet.Numerics.Statistics.Mcmc;
using Microsoft.EntityFrameworkCore;
using Z.BulkOperations;

namespace BaseNetCoreApi.Models.Repository
{
    public interface IGroupUserRepository : IRepository<GroupUser>
    {
        GroupUser? GetById(long Id);
        List<GroupUser> GetGroupUser(string maTinh, string maXa, string groupUserCode = "", string groupUserName = "");
        List<DSNhomQuyenViewModel> ConvertToDSNhomQuyenViewModel(List<GroupUser> lstConvert);
        List<GroupUser> ConvertToGroupUser(List<DSNhomQuyenViewModel> lstConvert);
        List<GroupUser> GetByListId(List<long> listId);
        ReturnCode Insert(GroupUser model);
        ReturnCode Insert(List<GroupUser> model);
    }
    public class GroupUserRepository : Repository<GroupUser>, IGroupUserRepository
    {
        private IMapper _mapper;
        private IWorkContextService _workContextService;
        public GroupUserRepository(IUnitOfWork unitOfWork, IQiCache qiCache, IMapper mapper, IWorkContextService workContextService) : base(unitOfWork, qiCache)
        {
            _mapper = mapper;
            _workContextService = workContextService;
        }

        public GroupUser? GetById(long Id)
        {
            return base.GetById(Id, "GroupUserId");
        }
        public List<GroupUser> GetGroupUser(string maTinh, string maXa, string groupUserCode = "", string groupUserName = "")
        {
            return _qiCache.GetByKey(
                getDataSource: () =>
                {
                    var temp = (from p in Table
                                where p.TinhMa == maTinh && p.XaMa == maXa
                                select p);
                    if (!string.IsNullOrEmpty(groupUserCode))
                        temp = temp.Where(x => x.GroupUserCode.Contains(groupUserCode));
                    if (!string.IsNullOrEmpty(groupUserName))
                        temp = temp.Where(x => x.GroupUserName.Contains(groupUserName));
                    return temp.ToList();
                },
                key: _qiCache.BuildCachedKey(CacheKeyPattern, "GetGroupUser", maTinh, maXa, groupUserCode, groupUserName),
                cacheTime: 300000);
        }

        public List<DSNhomQuyenViewModel> ConvertToDSNhomQuyenViewModel(List<GroupUser> lstConvert)
        {
            return lstConvert.Select(s => new DSNhomQuyenViewModel()
            {
                GroupUserId = s.GroupUserId,
                IsQuanTri = s.Isroot == 1,
                Ma = s.GroupUserCode,
                Ten = s.GroupUserName,
                Status = s.Status,
            }).ToList();
        }

        public List<GroupUser> ConvertToGroupUser(List<DSNhomQuyenViewModel> lstConvert)
        {
            return lstConvert.Select(s => new GroupUser()
            {
                GroupUserId = s.GroupUserId,
                Isroot = s.IsQuanTri ? 1 : 0,
                GroupUserCode = s.Ma,
                GroupUserName = s.Ten,
                Status = s.Status,
                TinhMa = _workContextService.MA_TINH,
                XaMa = _workContextService.MA_XA,
                CreateBy = _workContextService.NguoiDung.TenDangNhap,
                CreateAt = DateTime.Now,
            }).ToList();
        }

        public List<GroupUser> GetByListId(List<long> listId)
        {
            return _qiCache.GetByKey(
                    getDataSource: () =>
                    {
                        return Table.Where(q => listId.Contains(q.GroupUserId)).ToList();
                    },
                    key: _qiCache.BuildCachedKey(_cacheKeyPattern, "GetByListId", listId)
                    );
        }

        public ReturnCode Insert(GroupUser model)
        {
            return Insert(new List<GroupUser>() { model });
        }
        public ReturnCode Insert(List<GroupUser> model)
        {
            var ret = new ReturnCode();
            var lstMa = model.Select(s => s.GroupUserCode).ToList();
            var lstCheck = Table.Where(q => q.XaMa != null && lstMa.Contains(q.XaMa) && q.XaMa == _workContextService.MA_XA).ToList();
            if (lstCheck.Count > 0)
            {
                var lstMaTrung = lstCheck.Select(s => s.GroupUserCode).ToList();
                ret = new ReturnCode()
                {
                    ErrorMsg = $"Đã trùng mã nhóm quyền (${UltilHelper.ListToStringQuery(lstMaTrung)})"
                };
                return ret;
            }
            InsertOrUpdate(model, options =>
            {
                options.BatchSize = 100;
                options.ColumnPrimaryKeyExpression = key => new
                {
                    key.TinhMa,
                    key.XaMa,
                    key.GroupUserCode
                };
            });
            return ret;
        }
        public override void InsertOrUpdate(List<GroupUser> entities, Action<BulkOperation<GroupUser>>? options = null)
        {
            base.InsertOrUpdate(entities, options =>
            {
                options.BatchSize = 100;
                options.ColumnPrimaryKeyExpression = key => new
                {
                    key.TinhMa,
                    key.XaMa,
                    key.GroupUserCode
                };
            });
        }
    }
}
