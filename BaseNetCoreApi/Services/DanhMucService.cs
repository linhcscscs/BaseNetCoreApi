using BaseNetCoreApi.DomainService.Interface;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Models.Repository;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Values;

namespace BaseNetCoreApi.Services
{
    public interface IDanhMucService
    {
        HoSoXaDetailViewModel GetHoSoXaDetailViewModel();
        ReturnCode UpdateHoSoXaDetail(HoSoXaDetailEditViewModel model);
    }
    public class DanhMucService : IDanhMucService
    {
        private IDmXaRepository _dmXaRepository;
        private IWorkContextService _workContextService;
        private IDmTinhRepository _dmTinhRepository;
        private IDmHuyenRepository _dmHuyenRepository;
        private IUnitOfWork _unitOfWork;
        public DanhMucService(
            IDmXaRepository dmXaRepository,
            IWorkContextService workContextService,
            IDmHuyenRepository dmHuyenRepository,
            IDmTinhRepository dmTinhRepository,
            IUnitOfWork unitOfWork
            )
        {
            _dmXaRepository = dmXaRepository;
            _workContextService = workContextService;
            _dmHuyenRepository = dmHuyenRepository;
            _dmTinhRepository = dmTinhRepository;
            _unitOfWork = unitOfWork;
        }
        public HoSoXaDetailViewModel GetHoSoXaDetailViewModel()
        {
            var xa = _dmXaRepository.GetByMa(_workContextService.MA_XA);
            var tinh = _dmTinhRepository.GetByMa(xa?.MaTinh ?? "");
            var huyen = _dmHuyenRepository.GetByMa(xa?.MaHuyen ?? "");
            var result = new HoSoXaDetailViewModel()
            {
                HienThuocVungKhoKhan = xa?.IsVungKhoKhan == 1,
                MaPhuongXa = xa?.Ma ?? "",
                QuanHuyen = huyen?.Ma ?? "",
                TenPhuongXa = xa?.Ten ?? "",
                ThuTu = xa?.ThuTu ?? 0,
                TinhThanhPho = tinh?.Ten ?? ""
            };
            return result;
        }

        public ReturnCode UpdateHoSoXaDetail(HoSoXaDetailEditViewModel model)
        {
            var ret = new ReturnCode();
            var xa = _dmXaRepository.GetByMa(_workContextService.MA_XA);
            if (xa == null)
            {
                ret = new ReturnCode()
                {
                    ErrorMsg = "Không tìm thấy hồ sơ xã"
                };
                return ret;
            };
            xa.IsVungKhoKhan = model.HienThuocVungKhoKhan ? 1 : 0;
            _dmXaRepository.InsertOrUpdate(xa);
            _unitOfWork.SaveChanges();
            return ret;
        }
    }
}
