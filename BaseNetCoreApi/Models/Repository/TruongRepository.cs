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

namespace BaseNetCoreApi.Models.Repository
{
    public interface ITruongRepository : IRepository<Truong>
    {
        void UpdateIdHuyen(string maTinh, string maHuyen, string maXa);
        void InsertOrUpdate(List<Truong> lstTruong);
    }
    public class TruongRepository : Repository<Truong>, ITruongRepository
    {
        private IMapper _mapper;
        private IWorkContextService _workContextService;
        public TruongRepository(IUnitOfWork unitOfWork,
                                  IQiCache qiCache,
                                  IMapper mapper,
                                  IWorkContextService workContextService)
            : base(unitOfWork, qiCache)
        {
            _workContextService = workContextService;
            _mapper = mapper;
        }
        public void InsertOrUpdate(List<Truong> lstTruong)
        {
            base.InsertOrUpdate(lstTruong, options =>
            {
                options.BatchSize = 100;
                options.ColumnPrimaryKeyExpression = truong => new
                {
                    truong.Ma,
                    truong.MaNamHoc,
                    truong.MaTinh
                };
            });
        }
        public void UpdateIdHuyen(string maTinh, string maHuyen, string maXa)
        {
            var sql = @$"UPDATE t
                                SET t.ID_PHONG_GD=p.ID, t.ID_HUYEN=h.ID, t.ID_XA=x.ID
                                FROM dbo.TRUONG AS t
                                        JOIN dbo.PHONG_GD AS p ON t.MA_PHONG_GD=p.MA AND p.MA_NAM_HOC={_workContextService.MA_NAM_HOC}
                                        JOIN dbo.DM_HUYEN AS h ON t.MA_HUYEN=h.MA AND h.MA_NAM_HOC={_workContextService.MA_NAM_HOC}
                                        JOIN dbo.DM_XA AS x ON t.MA_XA=x.MA AND x.MA_NAM_HOC={_workContextService.MA_NAM_HOC}
                                WHERE t.MA_NAM_HOC={_workContextService.MA_NAM_HOC} ";
            if (!string.IsNullOrEmpty(maTinh))
            {
                sql += string.Format(@" AND t.MA_SO_GD='{0}' ", maTinh);
            }
            if (!string.IsNullOrEmpty(maHuyen))
            {
                sql += string.Format(@" AND t.MA_HUYEN='{0}' ", maHuyen);
            }
            if (!string.IsNullOrEmpty(maXa))
            {
                sql += string.Format(@" AND t.MA_XA='{0}' ", maXa);
            }
            _unitOfWork.ExcuteSqlCommand(sql);
        }
    }
}
