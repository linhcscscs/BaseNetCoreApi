using BaseNetCoreApi.DomainService;
using BaseNetCoreApi.DomainService.Interface;
using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.ContextProvider.Interface;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.Repository;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Services.Interface;
using BaseNetCoreApi.Values;

namespace BaseNetCoreApi.Services
{
    public class NguoiDungService : INguoiDungService
    {
        private INguoiDungRepository _nguoiDungRepository;
        private IWorkContextService _workContextService;
        private IGroupUserRepository _groupUserRepository;
        private INguoiDungToThonRepository _nguoiDungToThonRepository;
        private IQiCache _qiCache;
        public NguoiDungService(
            INguoiDungRepository nguoiDungRepository,
            IWorkContextService workContextService,
            IGroupUserRepository groupUserRepository,
            INguoiDungToThonRepository nguoiDungToThonRepository,
            IQiCache qiCache
            )
        {
            _nguoiDungRepository = nguoiDungRepository;
            _workContextService = workContextService;
            _groupUserRepository = groupUserRepository;
            _nguoiDungToThonRepository = nguoiDungToThonRepository;
            _qiCache = qiCache;
        }
        public List<NguoiDungViewModel> GetNguoiDungViewModel(string maTinh, string maHuyen, string maXa)
        {
            return _qiCache.GetByKey(
                getDataSource: () =>
                {
                    var lstNguoiDungToThon = _nguoiDungToThonRepository.GetByDonVi(maTinh, maHuyen, maXa);
                    var result = (from nguoiDung in _nguoiDungRepository.Table
                                  join groupUser in _groupUserRepository.Table
                                  on nguoiDung.GroupUserId equals groupUser.GroupUserId
                                  into tempGU
                                  from tempGuInto in tempGU.DefaultIfEmpty()
                                  where nguoiDung.MaXa == _workContextService.MA_XA
                                  && nguoiDung.MaHuyen == _workContextService.MA_HUYEN
                                  && nguoiDung.MaCapDonViHc == SysCapDonViHC.Xa
                                  && nguoiDung.IsRootSys == 0 || nguoiDung.IsRootSys == null
                                  select new NguoiDungViewModel()
                                  {
                                      NguoiDungId = nguoiDung.Id,
                                      HoTen = nguoiDung.HoTen,
                                      IsRoot = nguoiDung.IsRoot == 1,
                                      TrangThai = nguoiDung.TrangThai,
                                      GroupUserId = tempGuInto.GroupUserId,
                                      TenDangNhap = nguoiDung.TenDangNhap,
                                  }).ToList();
                    foreach (var item in result)
                    {
                        item.ListMaToThonPhuTrach = lstNguoiDungToThon.Where(q => q.ID_NGUOI_DUNG == item.NguoiDungId).Select(s => s.MA_TO_THON).ToList();
                    }
                    return result;
                },
                key: _qiCache.BuildCachedKey(_nguoiDungToThonRepository.CacheKeyPattern, _nguoiDungRepository.CacheKeyPattern, _groupUserRepository.CacheKeyPattern, "GetNguoiDungViewModel", maTinh, maHuyen, maXa),
                cacheTime: 300000
                );
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
