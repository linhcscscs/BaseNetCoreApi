using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Infrastructure.Repository;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.Dtos;
using AutoMapper;
using BaseNetCoreApi.Models.Entities;
using Microsoft.Data.SqlClient;
using BaseNetCoreApi.DomainService.Interface;
using BaseNetCoreApi.Values;

namespace BaseNetCoreApi.Models.Repository
{
    public interface INguoiDungToThonRepository : IRepository<NguoiDungToThon>
    {
        List<NguoiDungToThonEntity> GetByDonVi(string maTinh, string maHuyen, string maXa,
           int? maNamHoc = null, int? idNguoiDung = null, int? trangThai = null);
    }
    public class NguoiDungToThonRepository : Repository<NguoiDungToThon>, INguoiDungToThonRepository
    {
        private IWorkContextService _workContextService;
        public NguoiDungToThonRepository(
            IUnitOfWork unitOfWork,
            IQiCache qiCache,
            IWorkContextService workContextService)
            : base(unitOfWork, qiCache)
        {
            _workContextService = workContextService;
        }
        public List<NguoiDungToThonEntity> GetByDonVi(string maTinh, string maHuyen, string maXa,
           int? maNamHoc = null, int? idNguoiDung = null, int? trangThai = null)
        {
            maNamHoc = maNamHoc == null ? _workContextService.MA_NAM_HOC : maNamHoc;
            return _qiCache.GetByKey(
                getDataSource: () =>
                {
                    string strQuery = string.Format(@"SELECT ndth.ID_NGUOI_DUNG,
                                                    dmth.MA AS MA_TO_THON,
                                                    dmth.ID AS ID_TO_THON
                                                    ,dmth.TEN AS TEN_TO_THON
                                                    ,ndth.TRANG_THAI
                                                    ,CASE
                                                    WHEN ndth.TRANG_THAI IS NOT NULL 
                                                    THEN (CAST(ndth.TRANG_THAI AS BIT))
                                                    ELSE (CAST(0 AS BIT))
                                                    END AS TRANG_THAI_HIEN_THI
                                                    FROM NGUOI_DUNG_TO_THON ndth
                                                    RIGHT JOIN DM_TO_THON dmth ON ndth.ID_TO_THON = dmth.ID");
                    if (idNguoiDung != null)
                    {
                        strQuery += $" AND ndth.ID_NGUOI_DUNG = {idNguoiDung} ";
                    }
                    strQuery += string.Format(@$"WHERE dmth.MA_NAM_HOC = {maNamHoc}
                                                    AND dmth.MA_TINH = {maTinh}
                                                    AND dmth.MA_HUYEN = {maHuyen}
                                                    AND dmth.MA_XA = {maXa} ");
                    if (trangThai != null)
                    {
                        strQuery += $" AND ndth.TRANG_THAI = {trangThai}";
                    }
                    return _unitOfWork.SqlQuery<NguoiDungToThonEntity>(strQuery).ToList();
                },
                key: _qiCache.BuildCachedKey(CacheKeyPattern, "NGUOI_DUNG_TO_THON", "GetByDonVi", maTinh, maHuyen, maXa, maNamHoc, idNguoiDung, trangThai),
                cacheTime: CachingTime.CACHING_TIME_DEFAULT_IN_1_MINUTES
                );
        }
    }
}
