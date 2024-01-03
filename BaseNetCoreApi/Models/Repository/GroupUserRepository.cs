using AutoMapper;
using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Repository;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.ViewModel;
using DocumentFormat.OpenXml.InkML;
using MathNet.Numerics.Statistics.Mcmc;
using Microsoft.EntityFrameworkCore;

namespace BaseNetCoreApi.Models.Repository
{
    public interface IGroupUserRepository : IRepository<GroupUser>
    {
        GroupUser? GetById(long Id);
        List<GroupUser> GetGroupUser(string maTinh, string maXa, string groupUserCode = "", string groupUserName = "");
        List<DSNhomQuyenViewModel> ConvertToDSNhomQuyenViewModel(List<GroupUser> lstConvert);
        List<GroupUser> GetByListId(List<long> listId);
    }
    public class GroupUserRepository : Repository<GroupUser>, IGroupUserRepository
    {
        private IMapper _mapper;
        public GroupUserRepository(IUnitOfWork unitOfWork, IQiCache qiCache, IMapper mapper) : base(unitOfWork, qiCache)
        {
            _mapper = mapper;
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
    }
}
