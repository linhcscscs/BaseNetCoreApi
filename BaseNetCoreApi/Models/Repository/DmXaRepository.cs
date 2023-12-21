using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Infrastructure.Repository;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.Dtos;
using AutoMapper;
using BaseNetCoreApi.Helper;
using BaseNetCoreApi.DomainService.Interface;
using System.Text.Json;

namespace BaseNetCoreApi.Models.Repository
{
    public interface IDmXaRepository : IRepository<DmXa>
    {
        List<DMPhuongXaDto> GetListByListMaTinhMaHuyen(List<string>? lst_ma_tinh = null, List<string>? lst_ma_huyen = null, string? ten_xa = null, string? ma_xa = null, int? maNamHoc = null);
    }
    public class DmXaRepository : Repository<DmXa>, IDmXaRepository
    {
        private IMapper _mapper;
        private IWorkContextService _workContextService;
        public DmXaRepository(IUnitOfWork unitOfWork,
                                  IQiCache qiCache,
                                  IMapper mapper,
                                  IWorkContextService workContextService) 
            : base(unitOfWork, qiCache)
        {
            _workContextService = workContextService;
            _mapper = mapper;
        }

        public List<DMPhuongXaDto> GetListByListMaTinhMaHuyen(List<string>? lst_ma_tinh = null, List<string>? lst_ma_huyen = null, string? ten_xa = null, string? ma_xa = null, int? maNamHoc = null)
        {
            maNamHoc = maNamHoc ?? _workContextService.MA_NAM_HOC;
            List<DMPhuongXaDto> lstData = new List<DMPhuongXaDto>();
            return _qiCache.GetByKey(
                getDataSource: () =>
                {
                    var strQuery = $@"SELECT
                                        x.ID, x.MA, x.TEN
                                        ,t.TEN AS TEN_TINH
                                        ,t.MA AS MA_TINH
                                        ,h.TEN AS TEN_HUYEN
                                        ,h.MA AS MA_HUYEN
                                        FROM DM_XA x
                                        JOIN DM_HUYEN h ON x.MA_HUYEN = h.MA
                                        JOIN DM_TINH t ON h.MA_TINH = t.MA
                                        WHERE 
                                        h.MA_NAM_HOC = {maNamHoc}";
                    if (lst_ma_tinh?.Count > 0)
                    {
                        var lstQuery = UltilHelper.ListToStringQuery(lst_ma_tinh);
                        strQuery += string.Format(" AND t.MA IN ({0})", lstQuery);
                    }
                    if (lst_ma_huyen?.Count > 0)
                    {
                        var lstQuery = UltilHelper.ListToStringQuery(lst_ma_huyen);
                        strQuery += string.Format(" AND h.MA IN ({0})", lstQuery);
                    }
                    if (!string.IsNullOrEmpty(ten_xa))
                    {
                        strQuery += $" AND LOWER(x.TEN) LIKE %{ten_xa.ToLower().Normalize()}%";
                    }
                    if (!string.IsNullOrEmpty(ma_xa))
                    {
                        strQuery += $" AND LOWER(x.MA) LIKE %{ma_xa.ToLower().Normalize()}%";
                    }
                    lstData = _unitOfWork.SqlQuery<DMPhuongXaDto>(strQuery).ToList();
                    return lstData;
                },
                key: _qiCache.BuildCachedKey(CacheKeyPattern,
                                            "GetListByListMaTinhMaHuyen",
                                            JsonSerializer.Serialize(lst_ma_tinh),
                                            JsonSerializer.Serialize(lst_ma_huyen),
                                            ten_xa ?? "",
                                            maNamHoc),
                cacheTime: 300000
                );
        }
    }
}
