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
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
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
            return _groupUserRepository.ConvertToDSNhomQuyenViewModel(lstGrpUser);
        }
        public ReturnCode AddDsNhomQuyen(List<DSNhomQuyenViewModel> model, out List<DSNhomQuyenViewModel> result)
        {
            result = new List<DSNhomQuyenViewModel>();
            var lstInsert = _groupUserRepository.ConvertToGroupUser(model);
            var ret = _groupUserRepository.Insert(lstInsert);
            if (ret.Success)
            {
                _unitOfWork.SaveChanges();
                result = _groupUserRepository.ConvertToDSNhomQuyenViewModel(lstInsert);
            }
            return ret;
        }
        public string? AddDsNhomQuyenExcelUploadFile(IFormFile file)
        {
            string? filePath = null;
            UltilHelper.SaveTempExcelStaticFile(file, out filePath);
            return filePath;
        }
        public DataTable AddDsNhomQuyenExcelResult(string filePath)
        {
            return _qiCache.GetByKey(
                 () =>
                 {
                     DataTable dt = new DataTable();
                     #region add column
                     dt.Columns.Add("RowID");
                     dt.Columns.Add("id");
                     dt.Columns.Add("GroupUserCode");
                     dt.Columns.Add("GroupUserName");
                     dt.Columns.Add("Status");
                     #endregion
                     #region Add data
                     IWorkbook hssfwb = null;
                     using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                     {
                         string Ext = System.IO.Path.GetExtension(filePath); //<-get extention
                         switch (Ext.ToLower())
                         {
                             case ".xls":
                                 hssfwb = new HSSFWorkbook(stream);
                                 break;

                             case ".xlsx":
                                 hssfwb = new XSSFWorkbook(stream);
                                 break;
                         }
                     }
                     string sheetName = "Sheet1";
                     ISheet sheet = hssfwb.GetSheet(sheetName);
                     if (sheet == null)
                     {
                         return dt;
                     }
                     for (int row = 2 - 1; row <= sheet.LastRowNum; row++)
                     {
                         if (sheet.GetRow(row) != null) //null is when the row only contains empty cells 
                         {
                             DataRow dtrow = dt.NewRow();
                             dtrow["RowID"] = row + 1;
                             dtrow["id"] = row + 1;
                             int i = 0;
                             var isValid = true;
                             #region ma
                             string ma = "";
                             try
                             {
                                 ma = sheet.GetRow(row).GetCell(i).ToString().Trim();
                                 isValid = isValid && !string.IsNullOrEmpty(ma) &&
                                 _groupUserRepository.FirstOrDefault(q => q.GroupUserCode == ma) == null;
                             }
                             catch { }
                             i++;
                             dtrow["GroupUserCode"] = ma;
                             #endregion
                             #region ten
                             string ten = "";
                             try
                             {
                                 ten = sheet.GetRow(row).GetCell(i).ToString().Trim();
                                 isValid = isValid && !string.IsNullOrEmpty(ten);
                             }
                             catch { }
                             i++;
                             dtrow["GroupUsername"] = ten;
                             #endregion
                             #region trang_thai
                             string trang_thai = "";
                             try
                             {
                                 trang_thai = sheet.GetRow(row).GetCell(i).ToString().Trim();
                                 isValid = isValid && int.TryParse(trang_thai, out _);
                             }
                             catch { }
                             i++;
                             dtrow["Status"] = trang_thai;
                             #endregion
                             // Kiểm tra dòng có dữ liệu thì mới thêm vào trong datatable
                             if (!string.IsNullOrEmpty(ma) || !string.IsNullOrEmpty(ten) || !string.IsNullOrEmpty(trang_thai))
                                 dt.Rows.Add(dtrow);
                         }
                     }
                     return dt;
                     #endregion
                 },
                 key: _qiCache.BuildCachedKey("getDataExcelByTempUpload", filePath),
                 cacheTime: 300000
                 );
        }
        public ReturnCode AddDsNhomQuyenExcelSave(DSNhomQuyenImportExcelSave model, out List<ResultEntity> result)
        {
            var ret = new ReturnCode();
            var dt = AddDsNhomQuyenExcelResult(model.FilePath);
            var lstImport = new List<GroupUser>();
            var lstOBJ = _groupUserRepository.GetMulti(q => q.XaMa == _workContextService.MA_XA && q.TinhMa == _workContextService.MA_TINH).ToList();
            result = new List<ResultEntity>();
            foreach (DataRow row in dt.Rows)
            {
                ResultEntity res = new ResultEntity();
                res.Res = true;
                res.Msg = "Thành công";
                res.ResObject = row["RowID"];
                GroupUser detailEntity = new GroupUser();
                detailEntity = lstOBJ.FirstOrDefault(x => x.GroupUserCode.ToNormalizeLowerRelace() == row["GroupUserCode"].ToString().ToNormalizeLowerRelace());
                if (detailEntity != null && detailEntity.GroupUserId > 0 && !model.UpdateIfExists)
                {
                    res.ResObject = res.ResObject + "_" + "Mã";
                    res.Res = false;
                    res.Msg = "Mã đã tồn tại";
                    goto Endfor;
                }
                if (detailEntity == null) detailEntity = new GroupUser();
                #region Valid column
                res.ResObject = row["RowID"].ToString();
                string Error = "", ErrorDes = "";
                detailEntity.TinhMa = _workContextService.MA_TINH;
                detailEntity.XaMa = _workContextService.MA_XA;
                #region ma
                object ma = null;
                var cfgMa = UltilHelper.getConfigValid(SysDataType.String, 1, "", "", 50, 0, "", "", "", "", "", SysDataType.String);
                res.Res = ValidateHelper.ValidateObject(cfgMa, row["GroupUserCode"].ToString(), out ma, out Error, out ErrorDes);
                res.Msg = ErrorDes;
                #region Lỗi thì dừng check dòng của bảng
                if (!res.Res)
                {
                    res.ResObject = res.ResObject + "_" + "Mã";
                    goto Endfor;
                }
                #endregion
                #region Không lỗi thì lấy giá trị
                else
                {
                    detailEntity.GroupUserCode = ((string)ma).ToNormalize();
                }
                #endregion
                #endregion
                #region ten
                object ten = null;
                var cfgTen = UltilHelper.getConfigValid(SysDataType.String, 1, "", "", 50, 0, "", "", "", "", "", SysDataType.String);
                res.Res = ValidateHelper.ValidateObject(cfgTen, row["GroupUserName"].ToString(), out ten, out Error, out ErrorDes);
                res.Msg = ErrorDes;
                #region Lỗi thì dừng check dòng của bảng
                if (!res.Res)
                {
                    res.ResObject = res.ResObject + "_" + "Tên";
                    goto Endfor;
                }
                #endregion
                #region Không lỗi thì lấy giá trị
                else
                {
                    detailEntity.GroupUserName = ((string)ten).ToNormalize();
                }
                #endregion
                #endregion
                #region trang_thai
                object trang_thai = null;
                var cfgtrang_thai = UltilHelper.getConfigValid(SysDataType.Int32, 1, "0", "2", 150, 0, "", "", "", "", "", SysDataType.Int32);
                res.Res = ValidateHelper.ValidateObject(cfgtrang_thai, row["Status"].ToString(), out trang_thai, out Error, out ErrorDes);
                res.Msg = ErrorDes;
                #region Lỗi thì dừng check dòng của bảng
                if (!res.Res)
                {
                    res.ResObject = res.ResObject + "_" + "Trạng thái";
                    goto Endfor;
                }
                #endregion
                #region Không lỗi thì lấy giá trị
                else
                {
                    detailEntity.Status = (int)trang_thai;
                }
                #endregion
                #endregion
                #endregion
                if (res.Res) lstImport.Add(detailEntity);
            Endfor:
                result.Add(res);
            }
            if(!result.Any(a => !a.Res))
            {
                _groupUserRepository.InsertOrUpdate(lstImport);
                _unitOfWork.SaveChanges();
            }
            else
            {
                ret.ErrorMsg = "Ghi thất bại";
            }
            return ret;
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
                gu.Isroot = item.IsQuanTri ? 1 : 0;
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

                if (gum == null)
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
