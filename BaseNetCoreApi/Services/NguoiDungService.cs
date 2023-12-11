﻿using BaseNetCoreApi.DomainService;
using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.ContextProvider;
using BaseNetCoreApi.Infrastructure.Models.BO_GIAO_DUCEntities;
using BaseNetCoreApi.Models.BO_GIAO_DUCEntities;
using BaseNetCoreApi.Models.Entities;
using BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Service;
using BaseNetCoreApi.Values;
using NguoiDung = BaseNetCoreApi.Models.BO_GIAO_DUCEntities.NguoiDung;

namespace BaseNetCoreApi.Services
{
    public interface INguoiDungService
    {
        public NguoiDung? GetByNguoiDungId(decimal id, int? ma_nam_hoc = null);
        NguoiDung? GetByUsernameAndPassword(LoginRequest model);
    }
    public class NguoiDungService : INguoiDungService
    {
        private IBoGiaoDucContextProvider _contextProvider;
        private IQiCache _qiCache;
        private IWorkContextService _workContextService;
        private IContextDomainService _contextDomainService;
        public NguoiDungService(
            IBoGiaoDucContextProvider contextProvider,
            IQiCache qiCache,
            IWorkContextService workContextService,
            IContextDomainService contextDomainService
            )
        {
            _contextProvider = contextProvider;
            _qiCache = qiCache;
            _workContextService = workContextService;
            _contextDomainService = contextDomainService;
        }
        public NguoiDung? GetByNguoiDungId(decimal id, int? ma_nam_hoc = null)
        {
            return _contextDomainService.GetById<NguoiDung, BO_GIAO_DUCEntities>(_contextProvider, id, ma_nam_hoc);
        }
        public NguoiDung? GetByUsernameAndPassword(LoginRequest model)
        {
            var ma_nam_hoc = _workContextService.MA_NAM_HOC;

            var hashedPassword = AuthHelper.MD5(model.Password);
            NguoiDung? detail;
            using (var context = _contextProvider.GetContext(ma_nam_hoc, false))
            {
                detail = context.NguoiDungs.FirstOrDefault(q =>
                q.TenDangNhap == model.Username && q.MatKhau == hashedPassword &&
                ((q.MaTruong == model.ma_truong && q.MaSoGd == model.ma_so_gd && q.MaNamHoc == _workContextService.MA_NAM_HOC) 
                || q.IsMasterRootSys == 1));
            }
            return detail;
        }
        public NguoiDung? GetByNguoiDungId(RefreshAccessTokenRequest model)
        {
            var ma_nam_hoc = _workContextService.MA_NAM_HOC;

            NguoiDung? detail;
            using (var context = _contextProvider.GetContext(ma_nam_hoc, false))
            {
                detail = context.NguoiDungs.FirstOrDefault(q =>
                q.Id == model.NguoiDungId &&
                ((q.MaTruong == model.ma_truong && q.MaSoGd == model.ma_so_gd && q.MaNamHoc == _workContextService.MA_NAM_HOC)
                || q.IsMasterRootSys == 1));
            }
            return detail;
        }
    }

}
