using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.ContextProvider.Interface;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.Repository;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Service;
using BaseNetCoreApi.Services.Interface;

namespace BaseNetCoreApi.Services
{
    public class NguoiDungService : INguoiDungService
    {
        private IPhoCapGDContextProvider _contextProvider;
        private IQiCache _qiCache;
        private IWorkContextService _workContextService;
        private INguoiDungRepository _nguoiDungRepository;
        public NguoiDungService(
            IPhoCapGDContextProvider contextProvider,
            IQiCache qiCache,
            IWorkContextService workContextService,
            INguoiDungRepository nguoiDungRepository
            )
        {
            _contextProvider = contextProvider;
            _qiCache = qiCache;
            _workContextService = workContextService;
            _nguoiDungRepository = nguoiDungRepository;
        }
        public NguoiDung? GetByNguoiDungId(decimal id)
        {
            return _nguoiDungRepository.GetById(id);
        }
        public NguoiDung? GetByUsernameAndPassword(LoginRequest model)
        {
            var hashedPassword = AuthHelper.MD5(model.Password);
            return _nguoiDungRepository.FirstOrDefault(q =>
                q.TenDangNhap == model.Username && q.MatKhau == hashedPassword &&
                ((q.MaTinh == model.ma_tinh && q.MaHuyen == model.ma_huyen && q.MaXa == model.ma_xa)
                || q.IsRootSys == 1));
        }
    }

}
