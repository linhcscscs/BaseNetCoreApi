using AutoMapper;
using BaseNetCoreApi.DomainService.Interface;
using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Models.Model.CSDLBO;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.Repository;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Services.Interface;
using BaseNetCoreApi.Values;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Newtonsoft.Json;
using NPOI.SS.Formula.Functions;
using RTools_NTS.Util;

namespace BaseNetCoreApi.Services
{
    public class DongBoDanhMucService : IDongBoDanhMucService
    {
        private IDmHuyenRepository _dmHuyenRepository;
        private IDmXaRepository _dmXaRepository;
        private IDMPhongGdRepository _dmPhongGdRepository;
        private ITruongRepository _truongRepository;
        private IQiCache _qiCache;
        private IWorkContextService _workContextService;
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public DongBoDanhMucService(
            IDmHuyenRepository dmHuyenRepository,
            IDmXaRepository dmXaRepository,
            ITruongRepository truongRepository,
            IQiCache qiCache,
            IWorkContextService workContextService,
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IDMPhongGdRepository dMPhongGdRepository
            )
        {
            _dmHuyenRepository = dmHuyenRepository;
            _dmXaRepository = dmXaRepository;
            _qiCache = qiCache;
            _workContextService = workContextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _dmPhongGdRepository = dMPhongGdRepository;
            _truongRepository = truongRepository;
        }
        public async Task<DongBoDanhMucResponse> DongBoDanhMuc(DongBoDanhMucRequest model)
        {
            var result = new DongBoDanhMucResponse();
            var apiCsdl = new APICSDLHelper();
            //Get token
            await getTokenAsync(apiCsdl);
            if (model.IsSyncDMHuyen)
            {
                var tmpRet = await SyncDanhMucHuyen(apiCsdl, model.MaTinh, model.MaHuyen);
                result.SyncDMHuyen = tmpRet;
            }
            if (model.IsSyncDMXa)
            {
                var tmpRet = await SyncDanhMucXa(apiCsdl, model.MaTinh, model.MaHuyen, "");
                result.SyncDMXa = tmpRet;
            }
            if (model.IsSyncDMPhong)
            {
                var tmpRet = await SyncDanhMucPhong(apiCsdl,model.MaTinh, model.MaHuyen);
                result.SyncDMPhong = tmpRet;
            }
            if (model.IsSyncDSTruong)
            {
                var tmpRet = await SyncHoSoTruong(apiCsdl, model.MaTinh, model.MaHuyen, "", model.MaCapHoc);
                result.SyncDSTruong = tmpRet;
            }
            return result;
        }
        public async Task getTokenAsync(APICSDLHelper apiCsdl)
        {
            try
            {
                var getToken = await apiCsdl.getAsync(ConfigurationHelper.API_CSDL("Token"));
                var token = Newtonsoft.Json.JsonConvert.DeserializeObject<TokenResponse>(getToken)!;
                if (!apiCsdl.header.ContainsKey("token")) apiCsdl.header.Add("token", token.access_token);
            }
            catch
            {

            }
        }
        public async Task<List<DMHuyenResponseModel>> getDanhSachQuanHuyen(APICSDLHelper apiCsdl, string maTinh, string maHuyen)
        {
            try
            {
                var sendRequest = new DongBoRequest
                {
                    nam_hoc = _workContextService.MA_NAM_HOC,
                    ma_tinh = maTinh,
                    ma_huyen = maHuyen
                };
                //Responses
                var responseString = await apiCsdl.postDataAsync(sendRequest, ConfigurationHelper.API_CSDL("DS_HUYEN"));
                if (!string.IsNullOrEmpty(responseString))
                {
                    var responseData = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseData<string>>(responseString);
                    if (responseData.data != null)
                    {
                        var unZip = CompressHelper.Decompress(responseData.data.ToString());
                        List<DMHuyenResponseModel> responses = JsonConvert.DeserializeObject<List<DMHuyenResponseModel>>(unZip);
                        return responses;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }
        public async Task<List<DMXaResponseModel>> getDanhSachXaPhuong(APICSDLHelper apiCsdl, string maTinh, string maHuyen, string maXa)
        {
            try
            {
                //Request body
                var sendRequest = new DongBoRequest
                {
                    nam_hoc = _workContextService.MA_NAM_HOC,
                    ma_tinh = maTinh,
                    ma_huyen = maHuyen,
                    ma_xa = maXa,
                };
                //Responses
                var responseString = await apiCsdl.postDataAsync(sendRequest, ConfigurationHelper.API_CSDL("DS_XA"));
                if (!string.IsNullOrEmpty(responseString))
                {
                    var responseData = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseData<string>>(responseString);
                    if (responseData.data != null)
                    {
                        var unZip = CompressHelper.Decompress(responseData.data.ToString());
                        List<DMXaResponseModel> responses = JsonConvert.DeserializeObject<List<DMXaResponseModel>>(unZip);
                        return responses;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }
        public async Task<List<TruongResponseModel>> getDanhSachTruongPhoCapThuocDiaPhuong(APICSDLHelper apiCsdl, string maCapHoc, string maTinh, string maHuyen, string maXa)
        {
            try
            {
                //Request body
                var sendRequest = new DongBoRequest
                {
                    nam_hoc = _workContextService.MA_NAM_HOC,
                    ma_cap_hoc = maCapHoc,
                    ma_tinh = maTinh,
                    ma_huyen = maHuyen,
                    ma_xa = maXa,
                };
                //Responses
                var responseString = await apiCsdl.postDataAsync(sendRequest, ConfigurationHelper.API_CSDL("DS_TRUONG_PHO_CAP"));
                if (!string.IsNullOrEmpty(responseString))
                {
                    var responseData = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseData<string>>(responseString);
                    if (responseData.data != null)
                    {
                        var unZip = CompressHelper.Decompress(responseData.data.ToString());
                        List<TruongResponseModel> responses = JsonConvert.DeserializeObject<List<TruongResponseModel>>(unZip);
                        return responses;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }
        public async Task<List<TruongResponseModel>> getDanhSachTruongThuocDiaPhuong(APICSDLHelper apiCsdl, string maTinh, string maHuyen, string maXa)
        {
            try
            {
                //Request body
                var sendRequest = new DongBoRequest
                {
                    nam_hoc = _workContextService.MA_NAM_HOC,
                    ma_tinh = maTinh,
                    ma_huyen = maHuyen,
                    ma_xa = maXa,
                };
                //Responses
                var responseString = await apiCsdl.postDataAsync(sendRequest, ConfigurationHelper.API_CSDL("DS_TRUONG"));
                if (!string.IsNullOrEmpty(responseString))
                {
                    var responseData = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseData<string>>(responseString);
                    if (responseData.data != null)
                    {
                        var unZip = CompressHelper.Decompress(responseData.data.ToString());
                        List<TruongResponseModel> responses = JsonConvert.DeserializeObject<List<TruongResponseModel>>(unZip);
                        return responses;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }
        public async Task<List<PhongResponseModel>> getDanhSachPhong(APICSDLHelper apiCsdl, string maSo, string maPhong)
        {
            try
            {
                //Request body
                var sendRequest = new DongBoRequest
                {
                    nam_hoc = _workContextService.MA_NAM_HOC,
                    ma_so = maSo,
                    ma_phong = maPhong
                };
                //Responses
                var responseString = await apiCsdl.postDataAsync(sendRequest, ConfigurationHelper.API_CSDL("DS_PHONG"));
                if (!string.IsNullOrEmpty(responseString))
                {
                    var responseData = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseData<string>>(responseString);
                    if (responseData.data != null)
                    {
                        var unZip = CompressHelper.Decompress(responseData.data.ToString());
                        List<PhongResponseModel> responses = JsonConvert.DeserializeObject<List<PhongResponseModel>>(unZip);
                        return responses;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }

        public async Task<ReturnCode> SyncDanhMucHuyen(APICSDLHelper apiCsdl, string maTinh, string maHuyen)
        {
            ReturnCode ret = new ReturnCode();
            try
            {
                List<DmHuyen> lstHuyen = new List<DmHuyen>();
                var listHuyenRespone = await getDanhSachQuanHuyen(apiCsdl, maTinh, maHuyen);
                if (listHuyenRespone == null)
                {
                    ret.ErrorMsg = "Không tìm thấy bản ghi quận/huyện nào từ cơ sở dữ liệu!";
                    return ret;
                }
                foreach (var item in listHuyenRespone)
                {
                    DmHuyen detail = new DmHuyen();
                    detail.Ma = item.ma;
                    detail.MaNamHoc = item.ma_nam_hoc;
                    detail.MaTinh = item.ma_tinh;
                    detail.Ten = item.ten;
                    detail.ThuTu = item.thu_tu;
                    detail.Cap = item.cap;
                    detail.IdSource = item.id;
                    lstHuyen.Add(detail);
                }
                if (lstHuyen != null && lstHuyen.Count > 0)
                {
                    _dmHuyenRepository.InsertOrUpdate(lstHuyen);
                    _unitOfWork.SaveChanges();
                }
                return ret;
            }
            catch (Exception ex)
            {
                ret.ErrorMsg = "Có lỗi trong quá trình đồng bộ danh mục quận/huyện!";
                return ret;
            }
        }
        public async Task<ReturnCode> SyncDanhMucXa(APICSDLHelper apiCsdl, string maTinh, string maHuyen, string maXa)
        {
            ReturnCode ret = new ReturnCode();
            try
            {
                List<DmXa> lstXa = new List<DmXa>();
                var listXaRespone = await getDanhSachXaPhuong(apiCsdl, maTinh, maHuyen, maXa);
                if (listXaRespone == null)
                {
                    ret.ErrorMsg = "Không tìm thấy bản ghi xã/phường nào từ cơ sở dữ liệu!";
                    return ret;
                }
                foreach (var item in listXaRespone)
                {
                    DmXa detail = new DmXa();
                    detail.Ma = item.ma;
                    detail.MaNamHoc = item.ma_nam_hoc;
                    detail.MaTinh = item.ma_tinh;
                    detail.IdHuyen = null;
                    detail.MaHuyen = item.ma_huyen;
                    detail.Ten = item.ten;
                    detail.ThuTu = item.thu_tu;
                    detail.Cap = item.cap;
                    detail.MaXaSapNhap = item.ma_xa_sap_nhap;
                    detail.IdSource = item.id;
                    lstXa.Add(detail);
                }
                if (lstXa != null && lstXa.Count > 0)
                {
                    _dmXaRepository.InsertOrUpdate(lstXa);
                    //Update ID Huyen
                    _dmXaRepository.UpdateIdHuyen(maTinh, maHuyen);
                    _unitOfWork.SaveChanges();
                }
                return ret;
            }
            catch (Exception ex)
            {
                ret.ErrorMsg = "Có lỗi trong quá trình đồng bộ danh mục xã/phường!";
                return ret;
            }
        }
        public async Task<ReturnCode> SyncDanhMucPhong(APICSDLHelper apiCsdl, string maSGD, string maPGD)
        {
            ReturnCode ret = new ReturnCode();
            try
            {
                List<PhongGd> lstPhong = new List<PhongGd>();
                var listPhongRespone = await getDanhSachPhong(apiCsdl, maSGD, maPGD);
                if (listPhongRespone == null)
                {
                    ret.ErrorMsg = "Không tìm thấy bản ghi phòng nào từ cơ sở dữ liệu!";
                    return ret;
                }
                foreach (var item in listPhongRespone)
                {
                    PhongGd detail = new PhongGd();
                    detail.Ma = item.ma;
                    detail.MaNamHoc = item.ma_nam_hoc;
                    detail.MaSoGd = item.ma_so_gd;
                    detail.Ten = item.ten;
                    detail.MaTinh = item.ma_tinh;
                    detail.IdHuyen = null;
                    detail.MaHuyen = item.ma_huyen;
                    detail.DiaChi = item.dia_chi;
                    detail.DienThoai = item.dien_thoai;
                    detail.Email = item.email;
                    detail.Fax = item.fax;
                    detail.Website = item.website;
                    detail.TruongPhong = item.truong_phong;
                    detail.DienThoaiTruongPhong = item.dien_thoai_truong_phong;
                    detail.EmailTruongPhong = item.email_truong_phong;
                    detail.CanBoPhuTrach = item.can_bo_phu_trach;
                    detail.DienThoaiCanBoPhuTrach = item.dien_thoai_can_bo_phu_trach;
                    detail.EmailCanBoPhuTrach = item.email_can_bo_phu_trach;
                    detail.ThuTu = item.thu_tu;
                    detail.TrangThai = item.trang_thai;
                    detail.IdSource = item.id;
                    lstPhong.Add(detail);
                }
                if (lstPhong != null && lstPhong.Count > 0)
                {
                    _dmPhongGdRepository.InsertOrUpdate(lstPhong);
                    _dmPhongGdRepository.UpdateIdHuyen(maSGD, maPGD);
                    _unitOfWork.SaveChanges();
                }
                return ret;
            }
            catch (Exception ex)
            {
                ret.ErrorMsg = "Có lỗi trong quá trình đồng bộ danh mục phòng!";
                return ret;
            }
        }
        public async Task<ReturnCode> SyncHoSoTruong(APICSDLHelper apiCsdl, string maTinh, string maHuyen, string maXa, string capHoc)
        {
            var ret = new ReturnCode();
            try
            {
                List<Truong> lstTruong = new List<Truong>();
                var listTruongRespone = await getDanhSachTruongPhoCapThuocDiaPhuong(apiCsdl, capHoc, maTinh, maHuyen, maXa);
                if (listTruongRespone != null && listTruongRespone.Count > 0)
                {
                    var lstPhongGD = _dmPhongGdRepository.GetListPhongByMaSoGD(_workContextService.MA_TINH);
                    var listHuyen = _dmHuyenRepository.GetAll();
                    var listXa = _dmXaRepository.GetAll();
                    foreach (var item in listTruongRespone)
                    {
                        Truong detail = new Truong();
                        detail.MaNamHoc = item.ma_nam_hoc;
                        detail.MaSoGd = item.ma_so_gd;
                        detail.Ma = item.ma;
                        detail.Ten = item.ten;
                        detail.MaNhomCapHoc = item.ma_nhom_cap_hoc;
                        detail.DsCapHoc = item.ds_cap_hoc;
                        detail.IdPhongGd = null; ;
                        detail.MaPhongGd = item.ma_phong_gd;
                        detail.MaTinh = item.ma_tinh;
                        detail.IdHuyen = null; ;
                        detail.MaHuyen = item.ma_huyen;
                        detail.IdXa = null; ;
                        detail.MaXa = item.ma_xa;
                        detail.DiaChi = item.dia_chi;
                        detail.MaLoaiHinhTruong = item.ma_loai_hinh_truong;
                        detail.MaLoaiTruong = item.ma_loai_truong;
                        detail.MaKhuVuc = item.ma_khu_vuc;
                        detail.MaDatChuanDanhGiaClgd = item.ma_dat_chuan_danh_gia_clgd;
                        detail.MaTrucThuoc = item.ma_truc_thuoc;
                        detail.MaDuAn = item.ma_du_an;
                        detail.SoDiemTruong = item.so_diem_truong;
                        detail.DienThoai = item.dien_thoai;
                        detail.Email = item.email;
                        detail.Fax = item.fax;
                        detail.Website = item.website;
                        detail.ViTriBanDo = item.vi_tri_ban_do;
                        detail.HieuTruong = item.hieu_truong;
                        detail.DienThoaiHieuTruong = item.dien_thoai_hieu_truong;
                        detail.EmailHieuTruong = item.email_hieu_truong;
                        detail.IsCoChiBoDang = item.is_co_chi_bo_dang;
                        detail.IsDatChuanQg = item.is_dat_chuan_qg;
                        detail.IsTruongQuocTe = item.is_truong_quoc_te;
                        detail.IsCapMn = item.is_cap_mn;
                        detail.IsCapTh = item.is_cap_th;
                        detail.IsCapThcs = item.is_cap_thcs;
                        detail.IsCapThpt = item.is_cap_thpt;
                        detail.IsCapGdtx = item.is_cap_gdtx;
                        detail.LopCapMn = item.lop_cap_mn;
                        detail.LopCapMn5t = item.lop_cap_mn_5t;
                        detail.LopCapTh = item.lop_cap_th;
                        detail.LopCapThcs = item.lop_cap_thcs;
                        detail.LopCapThpt = item.lop_cap_thpt;
                        detail.LopCapGdtx = item.lop_cap_gdtx;
                        detail.ThuTu = item.thu_tu;
                        detail.MaVung = item.ma_vung;
                        detail.NguoiTao = item.nguoi_tao;
                        detail.NgayTao = item.ngay_tao;
                        detail.NguoiSua = item.nguoi_sua;
                        detail.NgaySua = item.ngay_sua;
                        detail.TrangThai = item.trang_thai;
                        detail.IsCoLopNho = item.is_co_lop_nho;
                        detail.IsNhoTren = item.is_nho_tren;
                        detail.IsNhoDuoi = item.is_nho_duoi;
                        detail.KinhTuyen = item.kinh_tuyen;
                        detail.ViTuyen = item.vi_tuyen;
                        detail.IdSource = item.id;
                        lstTruong.Add(detail);
                    }
                }
                if (lstTruong != null && lstTruong.Count > 0)
                {
                    _truongRepository.InsertOrUpdate(lstTruong);
                    _truongRepository.UpdateIdHuyen(maTinh, maHuyen, maXa);
                }
                return ret;
            }
            catch (Exception ex)
            {
                ret.ErrorMsg = "Có lỗi trong quá trình đồng bộ hồ sơ trường!";
                return ret;
            }
        }
    }
}
