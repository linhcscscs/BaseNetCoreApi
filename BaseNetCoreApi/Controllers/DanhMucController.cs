using AutoMapper;
using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Models.Dtos;
using BaseNetCoreApi.Models.Model;
using BaseNetCoreApi.Models.Repository;
using BaseNetCoreApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaseNetCoreApi.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class DanhMucController : ControllerBase
    {
        private IDmCapHocRepository _dmCapHocRepository;
        private IDmTinhRepository _dmTinhRepository;
        private IDmHuyenRepository _dmHuyenRepository;
        private IDmXaRepository _dmXaRepository;
        public IDmDanTocRepository _dmDanTocRepository;
        public IDmTonGiaoRepository _dmTonGiaoRepository;
        public IDmGioiTinhRepository _dmGioiTinhRepository;
        private ILogger<DanhMucController> _logger;
        public DanhMucController(IDmCapHocRepository dmCapHocRepository,
                                 IDmTinhRepository dmTinhRepository,
                                 IDmHuyenRepository dmHuyenRepository,
                                 IDmXaRepository dmXaRepository,
                                 IDmDanTocRepository dmDanTocRepository,
                                 IDmTonGiaoRepository dmTonGiaoRepository,
                                 IDmGioiTinhRepository dmGioiTinhRepository,
                                 ILogger<DanhMucController> logger)
        {
            _dmCapHocRepository = dmCapHocRepository;
            _dmTinhRepository = dmTinhRepository;
            _dmHuyenRepository = dmHuyenRepository;
            _dmXaRepository = dmXaRepository;
            _dmDanTocRepository = dmDanTocRepository;
            _dmTonGiaoRepository = dmTonGiaoRepository;
            _dmGioiTinhRepository = dmGioiTinhRepository;
            _logger = logger;
        }
        #region DM Đơn vị hành chính
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetDMTinhThanhPho()
        {
            try
            {
                var result = _dmTinhRepository.GetDMTinhThanhDto();
                return ReturnHelper.ReturnSuccess(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetDMTinhThanhPho");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetDMQuanHuyen()
        {
            try
            {
                var result = _dmHuyenRepository.GetListByListMaTinh();
                return ReturnHelper.ReturnSuccess(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetDMQuanHuyen");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult GetDMQuanHuyen(PaginationRequest<GetDmHuyenFilter> model)
        {
            try
            {
                var paginationModel = new PaginationModel<DMTinhHuyenDto>()
                {
                    PageIndex = model.PageIndex,
                    PageSize = model.PageSize,
                    Queryable = _dmHuyenRepository.GetListByListMaTinh(model.Filter.list_ma_tinh, model.Filter.ten_huyen).AsQueryable()
                };
                return ReturnHelper
                    .ReturnSuccess(new PaginationResponse<DMTinhHuyenDto>(paginationModel));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetDMQuanHuyen", [model]);
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetDMPhuongXa()
        {
            try
            {
                var result = _dmXaRepository.GetListByListMaTinhMaHuyen();
                return ReturnHelper.ReturnSuccess(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetDMPhuongXa");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }


        [HttpPost]
        [AllowAnonymous]
        public IActionResult GetDMPhuongXa(PaginationRequest<GetDmXaFilter> model)
        {
            try
            {
                var paginationModel = new PaginationModel<DMPhuongXaDto>()
                {
                    PageIndex = model.PageIndex,
                    PageSize = model.PageSize,
                    Queryable = _dmXaRepository.GetListByListMaTinhMaHuyen(model.Filter.list_ma_tinh, model.Filter.list_ma_huyen,model.Filter.ten_xa, model.Filter.ma_xa).AsQueryable()
                };
                return ReturnHelper
                    .ReturnSuccess(new PaginationResponse<DMPhuongXaDto>(paginationModel));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetDMPhuongXa", [model]);
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        #endregion
        #region Danh mục khác
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetDMCapHoc()
        {
            try
            {
                var result = _dmCapHocRepository.GetDMCapHocDto();
                return ReturnHelper.ReturnSuccess(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetDMCapHoc");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetDMDanToc()
        {
            try
            {
                var result = _dmDanTocRepository.GetDmDanTocDto();
                return ReturnHelper.ReturnSuccess(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetDMDanToc");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetDmTonGiao()
        {
            try
            {
                var result = _dmTonGiaoRepository.GetDmTonGiaoDtos();
                return ReturnHelper.ReturnSuccess(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetDmTonGiao");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetDmGioiTinh()
        {
            try
            {
                var result = _dmGioiTinhRepository.GetDmGioiTinhDto();
                return ReturnHelper.ReturnSuccess(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetDmGioiTinh");
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        #endregion
    }
}
