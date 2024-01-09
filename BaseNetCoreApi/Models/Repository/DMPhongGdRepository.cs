using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Infrastructure.Repository;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.Dtos;
using AutoMapper;
using BaseNetCoreApi.Helper;
using BaseNetCoreApi.DomainService.Interface;
using System.Text.Json;
using EFCore.BulkExtensions;
using MathNet.Numerics.Statistics.Mcmc;
using Microsoft.Extensions.Options;
using DocumentFormat.OpenXml.InkML;
using BaseNetCoreApi.Values;
using Z.BulkOperations;

namespace BaseNetCoreApi.Models.Repository
{
    public interface IDMPhongGdRepository : IRepository<PhongGd>
    {
        void InsertOrUpdate(List<PhongGd> phongGds);
        void UpdateIdHuyen(string maSGD = "", string maPGD = "");
        List<PhongGd> GetListPhongByMaSoGD(string maSoGD, int? maNamHoc = null);
    }
    public class DMPhongGdRepository : Repository<PhongGd>, IDMPhongGdRepository
    {
        private IMapper _mapper;
        private IWorkContextService _workContextService;
        public DMPhongGdRepository(IUnitOfWork unitOfWork,
                                  IQiCache qiCache,
                                  IMapper mapper,
                                  IWorkContextService workContextService)
            : base(unitOfWork, qiCache)
        {
            _workContextService = workContextService;
            _mapper = mapper;
        }
        public override void InsertOrUpdate(List<PhongGd> entities, Action<BulkOperation<PhongGd>>? options = null)
        {
            base.InsertOrUpdate(entities, options =>
            {
                options.BatchSize = 100;
                options.ColumnPrimaryKeyExpression = phong => new
                {
                    phong.Ma,
                    phong.MaNamHoc,
                    phong.MaSoGd
                };
            });
        }

        public void UpdateIdHuyen(string maSGD = "", string maPGD = "")
        {
            var sql = @$"UPDATE p
                                SET p.ID_HUYEN=h.ID
                                FROM dbo.PHONG_GD AS p
                                     JOIN dbo.DM_HUYEN AS h ON p.MA_HUYEN=h.MA AND h.MA_NAM_HOC={_workContextService.MA_NAM_HOC}
                                WHERE p.MA_NAM_HOC={_workContextService.MA_NAM_HOC} ";
            if (!string.IsNullOrEmpty(maSGD))
            {
                sql += string.Format(@" AND p.MA_SO_GD='{0}' ", maSGD);
            }
            if (!string.IsNullOrEmpty(maPGD))
            {
                sql += string.Format(@" AND p.MA='{0}' ", maPGD);
            }
            _unitOfWork.ExcuteSqlCommand(sql);
        }

        public List<PhongGd> GetListPhongByMaSoGD(string maSoGD, int? maNamHoc = null)
        {
            return _qiCache.GetByKey(
                getDataSource: () =>
                {
                    maNamHoc = maNamHoc != null ? maNamHoc : _workContextService.MA_NAM_HOC;
                    return (from p in Table
                            where p.TrangThai == 1
                                && p.MaSoGd == maSoGD
                                && p.MaNamHoc == maNamHoc
                            orderby p.ThuTu, p.Ten
                            select p).ToList();
                },
                key: _qiCache.BuildCachedKey(CacheKeyPattern, "GetListPhongBySoMa", maSoGD, maNamHoc!),
                cacheTime: CachingTime.CACHING_TIME_DEFAULT_IN_1_MINUTES
                );
        }
    }
}
