using BaseNetCoreApi.DomainService;
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
        private IContextProvider<BO_GIAO_DUCEntities> _contextProvider;
        private IQiCache _qiCache;
        private IWorkContextService _workContextService;
        private IContextDomainService _contextDomainService;
        public NguoiDungService(
            IContextProvider<BO_GIAO_DUCEntities> contextProvider,
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
                ((q.MaTruong == model.MA_TRUONG && q.MaSoGd == model.MA_SO_GD) || q.IsRoot == 1));
            }
            return detail;
        }
    }

}
