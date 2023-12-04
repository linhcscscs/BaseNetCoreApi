using AutoMapper;
using BaseNetCoreApi.DomainService;
using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.CacheProvider.CacheKey;
using BaseNetCoreApi.Infrastructure.ContextProvider;
using BaseNetCoreApi.Infrastructure.Models.QUAN_LY_THU_PHIEntities;
using BaseNetCoreApi.Models.Dtos;
using BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Service;
using BaseNetCoreApi.Values;
using System.Runtime.Caching;
using System.Text.Json;

namespace BaseNetCoreApi.Services
{
    public interface ICommonService
    {
        PaginationResponse<SoGd> GetSoGd(PaginationRequest<SoGdRequestDto> model);
        PaginationResponse<DMSoGd> GetDMSoGd(PaginationRequest<DMSoGdRequestDto> model);
        SoGd? GetSoGdByMa(string Ma);
        PaginationResponse<PhongGd> GetPhongGd(PaginationRequest<PhongGdRequestDto> model);
        PaginationResponse<DMPhongGd> GetDMPhongGd(PaginationRequest<DMPhongGdRequestDto> model);
        PaginationResponse<Truong> GetTruongPagination(PaginationRequest<TruongRequestDto> model);
        PaginationResponse<DMTruong> GetDMTruong(PaginationRequest<DMTruongRequestDto> model);
        List<DMCapHoc> GetDMCapHoc();
    }
    public class CommonService : ICommonService
    {
        private IContextDomainService _contextDomainService;
        private IQuanLyThuPhiContextProvider _contextProvider;
        private IWorkContextService _workContextService;
        private IQiCache _qiCache;
        private IMapper _mapper;
        public CommonService(IContextDomainService contextDomainService, IQuanLyThuPhiContextProvider contextProvider, IWorkContextService workContextService, IQiCache qiCache, IMapper mapper)
        {
            _contextDomainService = contextDomainService;
            _contextProvider = contextProvider;
            _workContextService = workContextService;
            _qiCache = qiCache;
            _mapper = mapper;
        }
        #region Sogd
        public PaginationResponse<SoGd> GetSoGd(PaginationRequest<SoGdRequestDto> model)
        {
            using (var context = _contextProvider.GetContext(_workContextService.MA_NAM_HOC, false))
            {
                var result = _qiCache.GetByKey(
                            getDataSource: () =>
                            {
                                var queryable = context.SoGds.AsQueryable();
                                if (!string.IsNullOrEmpty(model.Filter.ma_tinh))
                                {
                                    queryable = queryable.Where(q => q.MaTinh == model.Filter.ma_tinh);
                                }
                                return new PaginationResponse<SoGd>(new PaginationModel<SoGd>()
                                {
                                    PageIndex = model.PageIndex,
                                    PageSize = model.PageSize,
                                    Queryable = queryable,
                                });
                            },
                key: _qiCache.BuildCachedKey(CacheKey.SO_GD, "GetSoGd", JsonSerializer.Serialize(model)),
                            cacheTime: CachingTime.CACHING_TIME_DEFAULT_IN_24_HOURS);
                return result;
            }
        }
        public PaginationResponse<DMSoGd> GetDMSoGd(PaginationRequest<DMSoGdRequestDto> model)
        {
            using (var context = _contextProvider.GetContext(_workContextService.MA_NAM_HOC, false))
            {
                var result = _qiCache.GetByKey(
               getDataSource: () =>
               {
                   var queryable = context.SoGds.AsQueryable();
                   if (!string.IsNullOrEmpty(model.Filter.ma_tinh))
                   {
                       queryable = queryable.Where(q => q.MaTinh == model.Filter.ma_tinh);
                   }
                   return new PaginationResponse<DMSoGd>(new PaginationModel<DMSoGd>()
                   {
                       PageIndex = model.PageIndex,
                       PageSize = model.PageSize,
                       Queryable = queryable.Select(s => new DMSoGd()
                       {
                           Ma = s.Ma,
                           Ten = s.Ten,
                       }),
                   });
               },
               key: _qiCache.BuildCachedKey(CacheKey.SO_GD, "GetDMSoGd", JsonSerializer.Serialize(model))
               );
               return result;
            }
        }
        public SoGd? GetSoGdByMa(string Ma)
        {
            return _contextDomainService.GetByMa<SoGd, QUAN_LY_THU_PHIEntities>(_contextProvider, Ma, CacheKey.SO_GD);
        }
        #endregion
        #region PhongGd
        public PaginationResponse<PhongGd> GetPhongGd(PaginationRequest<PhongGdRequestDto> model)
        {
            using (var context = _contextProvider.GetContext(_workContextService.MA_NAM_HOC, false))
            {
                var result = _qiCache.GetByKey(
                    getDataSource: () =>
                    {
                        var maNamHoc = _workContextService.MA_NAM_HOC;
                        var queryable = context.PhongGds.AsQueryable();
                        if (!string.IsNullOrEmpty(model.Filter.ma_tinh))
                        {
                            queryable = queryable.Where(q => q.MaTinh == model.Filter.ma_tinh);
                        }
                        if (!string.IsNullOrEmpty(model.Filter.ma_huyen))
                        {
                            queryable = queryable.Where(q => q.MaHuyen == model.Filter.ma_huyen);
                        }
                        return new PaginationResponse<PhongGd>(new PaginationModel<PhongGd>()
                        {
                            PageIndex = model.PageIndex,
                            PageSize = model.PageSize,
                            Queryable = queryable,
                        });
                    },
                    key: _qiCache.BuildCachedKey(CacheKey.PHONG_GD, "GetPhongGd", JsonSerializer.Serialize(model))
                    );
                return result;
            }
        }
        public PaginationResponse<DMPhongGd> GetDMPhongGd(PaginationRequest<DMPhongGdRequestDto> model)
        {
            using (var context = _contextProvider.GetContext(_workContextService.MA_NAM_HOC, false))
            {
                var result = _qiCache.GetByKey(
                    getDataSource: () =>
                    {
                        var queryable = (from phongGd in context.PhongGds
                                         join soGd in context.SoGds
                                         on phongGd.MaSoGd equals soGd.Ma into soGdTemp
                                         from p in soGdTemp.DefaultIfEmpty()
                                         select new DMPhongGd
                                         {
                                             Ma = phongGd.Ma,
                                             Ten = phongGd.Ten,
                                             MaSoGd = p.Ma ?? "",
                                             TenSogd = p.Ten ?? ""
                                         });
                        return new PaginationResponse<DMPhongGd>(new PaginationModel<DMPhongGd>()
                        {
                            PageIndex = model.PageIndex,
                            PageSize = model.PageSize,
                            Queryable = queryable,
                        });
                    },
                    key: _qiCache.BuildCachedKey(CacheKey.PHONG_GD, "GetDMPhongGd", JsonSerializer.Serialize(model))
                    );
                return result;
            }
        }
        #endregion
        #region Truong
        public PaginationResponse<Truong> GetTruongPagination(PaginationRequest<TruongRequestDto> model)
        {
            var result = new PaginationResponse<Truong>();
            using (var context = _contextProvider.GetContext(_workContextService.MA_NAM_HOC, false))
            {
                result = _qiCache.GetByKey(
                            getDataSource: () =>
                            {
                                var queryable = context.Truongs.AsQueryable();
                                if (!string.IsNullOrEmpty(model.Filter.ma_so_gd))
                                {
                                    queryable = queryable.Where(q => q.MaSoGd == model.Filter.ma_so_gd);
                                }
                                if (!string.IsNullOrEmpty(model.Filter.ma_phong_gd))
                                {
                                    queryable = queryable.Where(q => q.MaPhongGd == model.Filter.ma_phong_gd);
                                }
                                if (!string.IsNullOrEmpty(model.Filter.ma_cap_hoc))
                                {
                                    if (model.Filter.ma_cap_hoc == SysCapHoc.C1)
                                    {
                                        queryable = queryable.Where(q => q.IsCapTh == 1);
                                    }
                                    if (model.Filter.ma_cap_hoc == SysCapHoc.C2)
                                    {
                                        queryable = queryable.Where(q => q.IsCapThcs == 1);
                                    }
                                    if (model.Filter.ma_cap_hoc == SysCapHoc.C3)
                                    {
                                        queryable = queryable.Where(q => q.IsCapThpt == 1);
                                    }
                                    if (model.Filter.ma_cap_hoc == SysCapHoc.GDTX)
                                    {
                                        queryable = queryable.Where(q => q.IsCapGdtx == 1);
                                    }
                                    if (model.Filter.ma_cap_hoc == SysCapHoc.MamNon)
                                    {
                                        queryable = queryable.Where(q => q.IsCapMn == 1);
                                    }
                                }
                                return new PaginationResponse<Truong>(new PaginationModel<Truong>()
                                {
                                    PageIndex = model.PageIndex,
                                    PageSize = model.PageSize,
                                    Queryable = queryable,
                                });
                            },
                key: _qiCache.BuildCachedKey(CacheKey.TRUONG, "GetTruong", JsonSerializer.Serialize(model)),
                            cacheTime: CachingTime.CACHING_TIME_DEFAULT_IN_24_HOURS);
            }
            return result;
        }
        public PaginationResponse<DMTruong> GetDMTruong(PaginationRequest<DMTruongRequestDto> model)
        {
            using (var context = _contextProvider.GetContext(_workContextService.MA_NAM_HOC, false))
            {
                var result = _qiCache.GetByKey(
                getDataSource: () =>
                {
                    var queryable = context.Truongs.Select(s => new DMTruong()
                    {
                        Id = s.Id,
                        DiaChi = s.DiaChi,
                        IdHuyen = s.IdHuyen,
                        IdPhongGd = s.IdPhongGd,
                        IdXa = s.IdXa,
                        IsCapGdtx = s.IsCapGdtx,
                        IsCapMn = s.IsCapMn,
                        IsCapTh = s.IsCapTh,
                        IsCapThcs = s.IsCapThcs,
                        IsCapThpt = s.IsCapThpt,
                        Ma = s.Ma,
                        MaHuyen = s.MaHuyen,
                        MaPhongGd = s.MaPhongGd,
                        MaXa = s.MaXa,
                        MaSoGd = s.MaSoGd,
                        MaTinh = s.MaTinh,
                        Ten = s.Ten
                    }).AsQueryable();
                    if (!string.IsNullOrEmpty(model.Filter.ma_so_gd))
                    {
                        queryable = queryable.Where(q => q.MaSoGd == model.Filter.ma_so_gd);
                    }
                    if (!string.IsNullOrEmpty(model.Filter.ma_phong_gd))
                    {
                        queryable = queryable.Where(q => q.MaPhongGd == model.Filter.ma_phong_gd);
                    }
                    if (!string.IsNullOrEmpty(model.Filter.ma_cap_hoc))
                    {
                        if (model.Filter.ma_cap_hoc == SysCapHoc.C1)
                        {
                            queryable = queryable.Where(q => q.IsCapTh == 1);
                        }
                        if (model.Filter.ma_cap_hoc == SysCapHoc.C2)
                        {
                            queryable = queryable.Where(q => q.IsCapThcs == 1);
                        }
                        if (model.Filter.ma_cap_hoc == SysCapHoc.C3)
                        {
                            queryable = queryable.Where(q => q.IsCapThpt == 1);
                        }
                        if (model.Filter.ma_cap_hoc == SysCapHoc.GDTX)
                        {
                            queryable = queryable.Where(q => q.IsCapGdtx == 1);
                        }
                        if (model.Filter.ma_cap_hoc == SysCapHoc.MamNon)
                        {
                            queryable = queryable.Where(q => q.IsCapMn == 1);
                        }
                    }
                    return new PaginationResponse<DMTruong>(new PaginationModel<DMTruong>()
                    {
                        PageIndex = model.PageIndex,
                        PageSize = model.PageSize,
                        Queryable = queryable,
                    });
                },
                key: _qiCache.BuildCachedKey(CacheKey.TRUONG, "GetDMTruong", JsonSerializer.Serialize(model))
                ); ;
                return result;
            }
        }
        public List<DMCapHoc> GetDMCapHoc()
        {
            List<DMCapHoc> result = new List<DMCapHoc>()
            {
                new DMCapHoc()
            {
                Ma = SysCapHoc.GDTX,
                Ten = "GDTX",
            },
                new DMCapHoc()
            {
                Ma = SysCapHoc.C1,
                Ten = "Tiểu học",
            },
                new DMCapHoc()
            {
                Ma = SysCapHoc.C2,
                Ten = "THCS",
            },
                new DMCapHoc()
            {
                Ma = SysCapHoc.C3,
                Ten = "THPT",
            },
                new DMCapHoc()
            {
                Ma = SysCapHoc.MamNon,
                Ten = "Mầm non",
            }
            };
            return result;
        }
        #endregion
    }
}
