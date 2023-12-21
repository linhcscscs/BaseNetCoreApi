using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Infrastructure.Repository;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.Dtos;
using BaseNetCoreApi.DomainService.Interface;
using DocumentFormat.OpenXml.InkML;
using BaseNetCoreApi.Helper;
using System.Text.Json;

namespace BaseNetCoreApi.Models.Repository
{
    public interface IDmHuyenRepository : IRepository<DmHuyen>
    {
        List<DMTinhHuyenDto> GetListByListMaTinh(List<string>? lst_ma_tinh = null, string ten_huyen = "", int? maNamHoc = null);
    }
    public class DmHuyenRepository : Repository<DmHuyen>, IDmHuyenRepository
    {
        private IWorkContextService _workContextService;
        public DmHuyenRepository(IUnitOfWork unitOfWork, IQiCache qiCache, IWorkContextService workContextService) : base(unitOfWork, qiCache)
        {
            _workContextService = workContextService;
        }

        public List<DMTinhHuyenDto> GetListByListMaTinh(List<string>? lst_ma_tinh = null, string ten_huyen = "", int? maNamHoc = null)
        {
            maNamHoc = maNamHoc ?? _workContextService.MA_NAM_HOC;
            List<DMTinhHuyenDto> lstData = new List<DMTinhHuyenDto>();
            return _qiCache.GetByKey(
                getDataSource: () =>
                {
                    var strQuery = $@"SELECT
                                        h.MA
                                        ,t.TEN AS TEN_TINH
                                        ,t.MA AS MA_TINH
                                        ,h.TEN AS TEN
                                        FROM DM_HUYEN h
                                        JOIN DM_TINH t ON h.MA_TINH = t.MA
                                        WHERE 
                                        h.MA_NAM_HOC = {maNamHoc}";
                    if (lst_ma_tinh?.Count > 0)
                    {
                        var lstMaTinhQuery = UltilHelper.ListToStringQuery(lst_ma_tinh);
                        strQuery += string.Format(" AND h.MA_TINH IN ({0})", lstMaTinhQuery);
                    }
                    if (!string.IsNullOrEmpty(ten_huyen))
                    {
                        strQuery += $" AND LOWER(h.TEN) LIKE %{ten_huyen.ToLower().Normalize()}%";
                    }
                    lstData = _unitOfWork.SqlQuery<DMTinhHuyenDto>(strQuery).ToList();
                    return lstData;
                },
                key: _qiCache.BuildCachedKey(CacheKeyPattern, "GetListByListMaTinh", JsonSerializer.Serialize(lst_ma_tinh), ten_huyen, maNamHoc),
                cacheTime: 300000
                );
        }
    }
}
