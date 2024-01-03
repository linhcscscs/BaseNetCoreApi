using BaseNetCoreApi.DomainService.Interface;
using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.CacheProvider;
using BaseNetCoreApi.Infrastructure.ContextProvider.Interface;
using BaseNetCoreApi.Infrastructure.Repository.Interface;
using BaseNetCoreApi.Models.Entities;
using BaseNetCoreApi.Models.Model.Excel;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.Repository;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Services.Interface;
using BaseNetCoreApi.Values;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.Excel;
using System.Data;

namespace BaseNetCoreApi.Services
{
    public class PermissionService : IPermissionService
    {
        #region Contructor
        private IPhoCapGDContextProvider _contextProvider;
        private IWorkContextService _workContextService;
        private IQiCache _qiCache;
        private IMenuRepository _menuRepository;
        private INguoiDungRepository _nguoiDungRepository;
        private IGroupUserRepository _groupUserRepository;
        private IGroupUserMenuRepository _groupUserMenuRepository;
        private IMenuService _menuService;
        private IUnitOfWork _unitOfWork;
        private IDmTinhRepository _dmTinhRepository;
        private IDmXaRepository _dmXaRepository;
        public PermissionService(IPhoCapGDContextProvider contextProvider,
            IWorkContextService workContextService,
            IQiCache qiCache,
            IMenuRepository menuRepository,
            INguoiDungRepository nguoiDungRepository,
            IGroupUserRepository groupUserRepository,
            IGroupUserMenuRepository groupUserMenuRepository,
            IMenuService menuService,
            IUnitOfWork unitOfWork,
            IDmTinhRepository dmTinhRepository,
            IDmXaRepository dmXaRepository)
        {
            _contextProvider = contextProvider;
            _workContextService = workContextService;
            _qiCache = qiCache;
            _menuRepository = menuRepository;
            _nguoiDungRepository = nguoiDungRepository;
            _groupUserRepository = groupUserRepository;
            _groupUserMenuRepository = groupUserMenuRepository;
            _menuService = menuService;
            _unitOfWork = unitOfWork;
            _dmTinhRepository = dmTinhRepository;
            _dmXaRepository = dmXaRepository;
        }
        #endregion

        #region Method
        private ReturnCode CheckGroupUserPermission(long GroupUserId)
        {
            var ret = new ReturnCode();
            // Check Permission
            var groupUser = _groupUserRepository.GetById(GroupUserId);
            if (groupUser == null)
            {
                ret = new ReturnCode(EReturnCode.NotFound);
                ret.ErrorMsg = "Không tìm thấy nhóm quyền";
                return ret;
            }
            if (groupUser.XaMa != _workContextService.MA_XA || 
                groupUser.TinhMa != _workContextService.MA_TINH)
            {
                ret = new ReturnCode(EReturnCode.Forbidden);
                return ret;
            }
            return ret;
        }
        public List<DSNhomQuyenViewModel> GetDsNhomQuyen(DSNhomQuyenRequest model)
        {
            var lstGrpUser = _groupUserRepository.GetGroupUser(_workContextService.MA_TINH, _workContextService.MA_XA, model.MaNhomQuyen, model.TenNhomQuyen) ?? new List<GroupUser>();
            return _groupUserRepository.ConvertToDSNhomQuyenViewModel(lstGrpUser) ;
        }
        public (string? filePath, string? fileName) GetDsNhomQuyenExcel(DSNhomQuyenRequest model)
        {
            var dataSource = GetDsNhomQuyen(model);

            DataTable dt = new DataTable();
            string serverPath = ConfigurationHelper.ServerMapPath;
            string path = String.Format("{0}\\ExportTemplates\\FileDynamic.xlsx", serverPath);
            string newName = "DSNhomQuyen.xlsx";

            List<ExcelHeaderEntity> lstHeader = new List<ExcelHeaderEntity>();
            List<ExcelEntity> lstColumn = new List<ExcelEntity>();
            lstHeader.Add(new ExcelHeaderEntity { name = "STT", colM = 1, rowM = 1, width = 10 });

            #region add column
            string colName = "";
            string colText = "";

            colName = "Ma";
            colText = "Mã";
            {
                DataColumn col = new DataColumn(colName);
                dt.Columns.Add(col);
                lstHeader.Add(new ExcelHeaderEntity { name = colText, colM = 1, rowM = 1, width = 20 });
                lstColumn.Add(new ExcelEntity { Name = colName, Align = XLAlignmentHorizontalValues.Left, Color = XLColor.Black, Type = "String" });
            }

            colName = "Ten";
            colText = "Tên";
            {
                DataColumn col = new DataColumn(colName);
                dt.Columns.Add(col);
                lstHeader.Add(new ExcelHeaderEntity { name = colText, colM = 1, rowM = 1, width = 22 });
                lstColumn.Add(new ExcelEntity { Name = colName, Align = XLAlignmentHorizontalValues.Left, Color = XLColor.Black, Type = "String" });
            }
            

            
            colName = "IsQuanTri";
            colText = "Là quản trị";
            {
                DataColumn col = new DataColumn(colName);
                dt.Columns.Add(col);
                lstHeader.Add(new ExcelHeaderEntity { name = colText, colM = 1, rowM = 1, width = 16 });
                lstColumn.Add(new ExcelEntity { Name = colName, Align = XLAlignmentHorizontalValues.Center, Color = XLColor.Black, Type = "check" });
            }

            colName = "Status";
            colText = "Trạng thái";
            {
                DataColumn col = new DataColumn(colName);
                dt.Columns.Add(col);
                lstHeader.Add(new ExcelHeaderEntity { name = colText, colM = 1, rowM = 1, width = 16 });
                lstColumn.Add(new ExcelEntity { Name = colName, Align = XLAlignmentHorizontalValues.Left, Color = XLColor.Black, Type = "String" });
            }
            #endregion
            foreach (var item in dataSource)
            {
                DataRow row = dt.NewRow();
                foreach (DataColumn col in dt.Columns)
                {
                    var sValue = (item.GetType().GetProperty(col.ColumnName)?.GetValue(item, null) ?? "").ToString();
                    row[col.ColumnName] = sValue;
                    if (col.ColumnName == "Status")
                    {
                        try
                        {
                            if (string.IsNullOrEmpty(sValue))
                            {
                                sValue = "0";
                            }
                            row[col.ColumnName] = TrangThaiValue.getText(int.Parse(sValue));
                        }
                        catch { }
                    }
                    if (col.ColumnName == "ISRoot")
                    {
                        try
                        {
                            if (string.IsNullOrEmpty(sValue))
                            {
                                sValue = "0";
                            }
                            row[col.ColumnName] = sValue == "1" ? "x" : "";
                        }
                        catch { }
                    }
                }
                dt.Rows.Add(row);
            }
            int rowHeaderStart = 7;
            int rowStart = 8;
            string colStart = "A";
            string colEnd = ExcelHelper.GetExcelColumnName(lstColumn.Count);
            List<ExcelHeaderEntity> listCell = new List<ExcelHeaderEntity>();
            string don_vi_chu_quan = _dmTinhRepository.GetByMa(_workContextService.MA_TINH)?.Ten ?? "";
            string ten_don_vi = _dmTinhRepository.GetByMa(_workContextService.MA_XA)?.Ten ?? "";
            string tieuDe = "DANH SÁCH NHÓM QUYỀN";
            string hocKyNamHoc = "Ngày " + DateTime.Now.ToString("dd/MM/yyyy");
            listCell.Add(new ExcelHeaderEntity { name = don_vi_chu_quan, colM = 3, rowM = 1, colName = "A", rowIndex = 1, Align = XLAlignmentHorizontalValues.Left });
            listCell.Add(new ExcelHeaderEntity { name = ten_don_vi, colM = 3, rowM = 1, colName = "A", rowIndex = 2, Align = XLAlignmentHorizontalValues.Left });
            listCell.Add(new ExcelHeaderEntity { name = tieuDe, colM = lstColumn.Count + 1, rowM = 1, colName = "A", rowIndex = 4, fontSize = 14, Align = XLAlignmentHorizontalValues.Center });
            listCell.Add(new ExcelHeaderEntity { name = hocKyNamHoc, colM = lstColumn.Count + 1, rowM = 1, colName = "A", rowIndex = 5, fontSize = 14, Align = XLAlignmentHorizontalValues.Center });
            string nameFileOutput = newName;
            return ExcelHelper.ExportExcelDynamic(serverPath, path, newName, nameFileOutput, 1, listCell, rowHeaderStart, rowStart, colStart, colEnd, dt, lstHeader, lstColumn, true);
        }
        public ReturnCode EditDsNhomQuyen(DSNhomQuyenEditModel model)
        {
            var ret = new ReturnCode();
            // Check Permission
            var isValid = model.Data.Any(a => !CheckGroupUserPermission(a.GroupUserId).Success);
            if (!isValid)
            {
                return new ReturnCode(EReturnCode.Forbidden);
            }
            var lstInsertOrUpdate = new List<GroupUser>();
            foreach (var item in model.Data)
            {
                var gu = _groupUserRepository.GetById(item.GroupUserId);
                gu.GroupUserCode = item.Ma;
                gu.GroupUserName = item.Ten;
                gu.Isroot = item.IsQuanTri? 1 : 0;
                gu.Status = item.Status;
                lstInsertOrUpdate.Add(gu);
            }
            _groupUserRepository.InsertOrUpdate(lstInsertOrUpdate);
            _unitOfWork.SaveChanges();
            return ret;
        }
        public ReturnCode DeleteDsNhomQuyen(DSNhomQuyenDeleteModel model)
        {
            var ret = new ReturnCode();
            // Check Permission
            var isValid = model.ListId.Any(a => !CheckGroupUserPermission(a).Success);
            if (!isValid)
            {
                return new ReturnCode(EReturnCode.Forbidden);
            }
            var lstInsertOrUpdate = new List<GroupUser>();
            var lstDelete = _groupUserRepository.GetByListId(model.ListId);
            _groupUserRepository.Remove(lstDelete);
            _unitOfWork.SaveChanges();
            return ret;
        }
        public ReturnCode GetGroupUserMenuEntity(long GroupUserId, out List<GroupUserMenuEntity> result)
        {
            var ret = new ReturnCode();
            result = new List<GroupUserMenuEntity>();

            // Check Permission
            ret = CheckGroupUserPermission(GroupUserId);
            if (!ret.Success) return ret;

            // Get Nhóm quyền
            result = _groupUserMenuRepository.getQuyenByGroupUserID(GroupUserId);
            return ret;
        }
        public ReturnCode EditGroupUserMenuEntity(GroupUserMenuEntityEditViewModel model)
        {
            var ret = new ReturnCode();
            // Check Permission
            ret = CheckGroupUserPermission(model.GroupUserId);
            if (!ret.Success) return ret;
            var lstGroupUserMenu = GetGroupUserMenusByGroupUserId(model.GroupUserId) ?? new List<GroupUserMenu>();
            var lstMenuId = _menuRepository.GetAll()?.Select(s => s.MenuId).ToList() ?? new List<long>();
            var lstInsertOrUpdate = new List<GroupUserMenu>();
            foreach (var gume in model.Data)
            {
                if (!lstMenuId.Contains(gume.MenuID))
                {
                    continue;
                }

                var gum = lstGroupUserMenu.FirstOrDefault(q => q.GroupUserId == gume.GroupUserID && q.MenuId == gume.MenuID);

                if(gum == null)
                {
                    gum = new GroupUserMenu();
                }

                gum.GroupUserMenuId = gum.MenuId;
                gum.MenuId = gum.MenuId;

                gum.IsAdd = gume.IsAdd ?? 0;
                gum.IsAuth = gume.IsAuth ?? 0;
                gum.IsDelete = gume.IsDelete ?? 0;
                gum.IsView = gume.IsView ?? 0;
                gum.IsEdit = gume.IsEdit ?? 0;
                gum.IsUpload = gume.IsUpload ?? 0;
                lstInsertOrUpdate.Add(gum);
            }
            _groupUserMenuRepository.InsertOrUpdate(lstInsertOrUpdate);
            _unitOfWork.SaveChanges();
            return ret;
        }

        public List<GroupUserMenu> GetGroupUserMenusByGroupUserId(long GroupUserId)
        {
            return _qiCache.GetByKey(
                       getDataSource: () => _groupUserMenuRepository.GetMulti(q => q.GroupUserId == GroupUserId).ToList(),
                       key: _qiCache.BuildCachedKey(_groupUserMenuRepository.CacheKeyPattern,
                                                    "GetGroupUserMenusByGroupUserId", GroupUserId),
                       cacheTime: CachingTime.CACHING_TIME_DEFAULT_IN_5_MINUTES
                    );
        }

        public GroupUser? GetGroupUserByNguoiDung(decimal nguoiDungId)
        {
            return _qiCache.GetByKey(
               getDataSource: () =>
               {
                   var nguoiDung = _nguoiDungRepository.GetById(nguoiDungId);
                   if (nguoiDung == null)
                   {
                       return new GroupUser();
                   };
                   return _groupUserRepository.FirstOrDefault(q => q.GroupUserId == nguoiDung.GroupUserId 
                   //&& q.Status == TrangThaiValue.HIEU_LUC
                   );
               },
               key: _qiCache.BuildCachedKey(_nguoiDungRepository.CacheKeyPattern,  
                                            _groupUserRepository.CacheKeyPattern, 
                                            "GetGroupUserByNguoiDung", nguoiDungId),
               cacheTime: CachingTime.CACHING_TIME_DEFAULT_IN_5_MINUTES
               );
        }

        public List<GroupUserMenu> GetGroupUserMenuByNguoiDung(decimal nguoiDungId)
        {
            var groupUser = GetGroupUserByNguoiDung(nguoiDungId);
            if (groupUser == null)
            {
                return new List<GroupUserMenu>();
            }
            return _qiCache.GetByKey(
               getDataSource: () => _groupUserMenuRepository
                        .Include(i => i.Menu)
                        .Where(q => q.GroupUserId == groupUser.GroupUserId && q.Menu.IsView == 1)
                        .ToList(),
               key: _qiCache.BuildCachedKey(_nguoiDungRepository.CacheKeyPattern,
                                            _groupUserRepository.CacheKeyPattern, 
                                            _groupUserMenuRepository.CacheKeyPattern, 
                                            "GetGroupUserMenuByNguoiDung", nguoiDungId),
               cacheTime: CachingTime.CACHING_TIME_DEFAULT_IN_5_MINUTES
               );
        }

        public List<GroupUserMenu> GetGroupUserMenuByNguoiDungByPath(decimal nguoiDungId, string path)
        {

            var result = new List<GroupUserMenu>();
            var menu = _menuService.GetMenuByPath(path);
            if (menu == null)
            {
                return result;
            }

            var lstGroupUser = GetGroupUserMenuByNguoiDung(nguoiDungId);

            return _qiCache.GetByKey(
               getDataSource: () => lstGroupUser
                        .Where(q => menu.MenuId == q.MenuId).ToList(),
               key: _qiCache.BuildCachedKey(_groupUserMenuRepository.CacheKeyPattern, "GetGroupUserMenuByNguoiDungByPath", nguoiDungId, path),
               cacheTime: CachingTime.CACHING_TIME_DEFAULT_IN_5_MINUTES
               );
        }
        #endregion
    }
}
