using BaseNetCoreApi.Models.Model.Excel;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using SharpCompress.Common;
using System.Data;

namespace BaseNetCoreApi.Helper
{
    public static class ExcelHelper
    {
        public static string GetExcelColumnName(int columnNumber)
        {
            int dividend = columnNumber;
            string columnName = String.Empty;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                dividend = (int)((dividend - modulo) / 26);
            }

            return columnName;
        }
        public static int ExcelColumnNameToNumber(string columnName)
        {
            try
            {
                if (string.IsNullOrEmpty(columnName)) throw new ArgumentNullException("columnName");

                columnName = columnName.ToUpperInvariant();

                int sum = 0;

                for (int i = 0; i < columnName.Length; i++)
                {
                    sum *= 26;
                    sum += (columnName[i] - 'A' + 1);
                }

                return sum;
            }
            catch (Exception ex)
            {
                return 1;
            }
        }
        public static (string? filePath, string? fileName) ExportExcelDynamic(string serverPath, string path, string newName, string nameFileOutput, int indexSheet, List<ExcelHeaderEntity> listCell
               , int rowHeaderStart, int rowStart, string colStart, string colEnd, DataTable dt, List<ExcelHeaderEntity> lstHeader, List<ExcelEntity> lstColumn, bool have_stt)
        {
            Guid strGuid = Guid.NewGuid();
            newName = strGuid.ToString() + newName;
            string pathNew = String.Format("{0}\\FileFolder\\Internal\\Temp\\{1}", serverPath, newName);
            try
            {
                System.IO.File.Copy(path, pathNew, true);
                var workbook = new XLWorkbook(pathNew);
                var ws = workbook.Worksheet(indexSheet);
                #region Set cell
                if (listCell != null && listCell.Count > 0)
                {
                    foreach (var item in listCell)
                    {
                        string colEndCell = GetExcelColumnName(ExcelColumnNameToNumber(item.colName) + item.colM - 1);
                        var itemCell = ws.Range(string.Format(@"{0}{1}:{2}{3}", item.colName, item.rowIndex, colEndCell, item.rowIndex + item.rowM - 1));
                        ws.Range(string.Format(@"{0}{1}:{2}{3}", item.colName, item.rowIndex, colEndCell, item.rowIndex + item.rowM - 1)).Merge();
                        itemCell.Value = item.name;

                        itemCell.Style.Font.Bold = item.Bold;
                        if (item.Align != null)
                            itemCell.Style.Alignment.Horizontal = item.Align.Value;
                        if (item.fontSize != null)
                            itemCell.Style.Font.FontSize = item.fontSize.Value;

                    }
                }
                #endregion
                #region SetHeader
                if (lstHeader != null && lstHeader.Count > 0)
                {
                    for (int i = 0; i < lstHeader.Count; i++)
                    {
                        var item = lstHeader[i];
                        string colName = colStart;
                        int rowIndex = rowHeaderStart;
                        #region Có cha
                        if (item.parentIndex != null)
                        {
                            ExcelHeaderEntity parentItem = lstHeader[item.parentIndex.Value];
                            if (parentItem.lstChild == null || parentItem.lstChild.Count == 0)
                            {
                                colName = parentItem.colName;
                                parentItem.lstChild = new List<ExcelHeaderEntity>();
                            }
                            else
                            {
                                string colnameParent = parentItem.lstChild[parentItem.lstChild.Count - 1].colName;
                                colName = GetExcelColumnName(ExcelColumnNameToNumber(parentItem.lstChild[parentItem.lstChild.Count - 1].colName) + parentItem.lstChild[parentItem.lstChild.Count - 1].colM);
                            }
                            rowIndex = parentItem.rowIndex + parentItem.rowM;
                            item.colName = colName;
                            item.rowIndex = rowIndex;
                            parentItem.lstChild.Add(item);
                            lstHeader[item.parentIndex.Value] = parentItem;
                        }
                        #endregion
                        #region Không cha
                        else
                        {
                            if (i > 0) colName = GetExcelColumnName(ExcelColumnNameToNumber(lstHeader[i - 1].colName) + 1);
                            rowIndex = rowHeaderStart;
                            item.colName = colName;
                            item.rowIndex = rowIndex;
                        }
                        #endregion
                        lstHeader[i] = item;
                        string colEndCell = GetExcelColumnName(ExcelColumnNameToNumber(item.colName) + item.colM - 1);
                        var itemCell = ws.Range(string.Format(@"{0}{1}:{2}{3}", item.colName, item.rowIndex, colEndCell, item.rowIndex + item.rowM - 1));
                        ws.Range(string.Format(@"{0}{1}:{2}{3}", item.colName, item.rowIndex, colEndCell, item.rowIndex + item.rowM - 1)).Merge();
                        itemCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        itemCell.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        itemCell.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                        itemCell.Style.Border.TopBorderColor = XLColor.Black;
                        itemCell.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                        itemCell.Style.Border.BottomBorderColor = XLColor.Black;
                        itemCell.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                        itemCell.Style.Border.LeftBorderColor = XLColor.Black;
                        itemCell.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                        itemCell.Style.Border.RightBorderColor = XLColor.Black;
                        itemCell.Style.Font.Bold = item.Bold;
                        if (item.WrapText != null)
                            itemCell.Style.Alignment.WrapText = item.WrapText.Value;

                        var itemcol = ws.Column(item.colName);
                        if (item.width != null)
                        {
                            itemCell.Style.Alignment.WrapText = true;
                            itemcol.Width = item.width.Value;
                        }
                        var itemrow = ws.Row(item.rowIndex);
                        if (item.height != null)
                        {
                            itemrow.Height = item.height.Value;
                        }
                        else
                        {
                            itemrow.Height = 24;
                        }
                        itemCell.Value = item.name;
                        if (item.Color != null)
                        {
                            itemCell.Style.Font.FontColor = item.Color;
                        }
                    }
                }
                #endregion
                #region Set Data
                string rangeData = string.Format("{0}{2}:{1}{3}", colStart, colEnd, rowStart, rowStart + dt.Rows.Count - 1);
                var rngNumbers = ws.Range(rangeData);
                int index = 1, indexStart = rowStart;
                foreach (DataRow row in dt.Rows)
                {

                    if (have_stt)
                    {
                        rngNumbers.Cell(index, 1).Value = index.ToString();
                        rngNumbers.Cell(index, 1).Style.Alignment.WrapText = true;
                        rngNumbers.Cell(index, 1).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                        rngNumbers.Cell(index, 1).Style.Border.TopBorderColor = XLColor.Black;
                        rngNumbers.Cell(index, 1).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                        rngNumbers.Cell(index, 1).Style.Border.BottomBorderColor = XLColor.Black;
                        rngNumbers.Cell(index, 1).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                        rngNumbers.Cell(index, 1).Style.Border.LeftBorderColor = XLColor.Black;
                        rngNumbers.Cell(index, 1).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                        rngNumbers.Cell(index, 1).Style.Border.RightBorderColor = XLColor.Black;
                        rngNumbers.Cell(index, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        for (int i = 0; i < lstColumn.Count; i++)
                        {
                            bool is_daset = false;
                            string valCell = row[lstColumn[i].Name] == null ? " " : row[lstColumn[i].Name].ToString().Replace("<b>", "").Replace("</b>", "");
                            switch (lstColumn[i].Type)
                            {
                                case "String":
                                    break;
                                case "%":
                                    try
                                    {
                                        decimal val = Convert.ToDecimal(row[lstColumn[i].Name].ToString()) * 100;
                                        valCell = val.ToString("#,##0.00") + "%";
                                    }
                                    catch { }
                                    break;
                                case "LenLop":
                                    string len_lop = "Chưa xét";
                                    try
                                    {
                                        string tmp = row[lstColumn[i].Name].ToString().ToLower();
                                        if (tmp == "1" || tmp == "true")
                                            len_lop = "Lên lớp";
                                        else if (tmp == "0" || tmp == "false")
                                            len_lop = "Lưu ban";
                                        else len_lop = "Chưa xét";
                                    }
                                    catch { }
                                    valCell = len_lop;
                                    break;
                                case "CoKhong":
                                    string co_khong = "";
                                    try
                                    {
                                        string tmp = row[lstColumn[i].Name].ToString().ToLower();
                                        if (tmp == "1" || tmp == "true")
                                            co_khong = "Có";
                                        else if (tmp == "0" || tmp == "false")
                                            co_khong = "";
                                        else co_khong = "";
                                    }
                                    catch { }
                                    valCell = co_khong;
                                    break;
                                case "check":
                                    string check = "";
                                    try
                                    {
                                        string tmp = row[lstColumn[i].Name].ToString().ToLower();
                                        if (tmp == "1" || tmp == "true")
                                            check = "x";
                                        else check = "";
                                    }
                                    catch { }
                                    valCell = check;
                                    break;
                                case "Number":
                                    rngNumbers.Cell(index, i + 2).Style.NumberFormat.Format = "#,###";
                                    try
                                    {
                                        int valCellF = Convert.ToInt32(valCell.Replace(",", ""));
                                        if (valCellF == 0)
                                        {
                                            rngNumbers.Cell(index, i + 2).SetValue("0");
                                        }
                                        else
                                        {
                                            rngNumbers.Cell(index, i + 2).SetValue(valCellF);
                                        }

                                        is_daset = true;
                                    }
                                    catch { }
                                    break;
                                case "Decimal":
                                    if (!string.IsNullOrEmpty(lstColumn[i].NumberFormat))
                                        rngNumbers.Cell(index, i + 2).Style.NumberFormat.Format = lstColumn[i].NumberFormat;
                                    else rngNumbers.Cell(index, i + 2).Style.NumberFormat.Format = "#,##0.00";
                                    try
                                    {
                                        decimal valCellF = Convert.ToDecimal(valCell.Replace(",", ""));
                                        rngNumbers.Cell(index, i + 2).SetValue(valCellF);
                                        is_daset = true;
                                    }
                                    catch { }
                                    break;
                                case "Date":
                                    DateTime ngay1 = new DateTime();
                                    try
                                    {
                                        ngay1 = Convert.ToDateTime(row[lstColumn[i].Name].ToString());
                                        valCell = ngay1.ToString("dd/MM/yyyy");
                                    }
                                    catch { }
                                    break;
                                case "DeteTime":
                                    DateTime ngay2 = new DateTime();
                                    try
                                    {
                                        ngay2 = Convert.ToDateTime(row[lstColumn[i].Name].ToString());
                                        valCell = ngay2.ToString("dd/MM/yyyy hh:mm:ss");
                                    }
                                    catch { }
                                    break;
                            }
                            if (!is_daset)
                                rngNumbers.Cell(index, i + 2).SetValue(valCell);
                            if (row[lstColumn[i].Name].ToString().Contains("<b>"))
                                rngNumbers.Cell(index, i + 2).Style.Font.Bold = true;
                            rngNumbers.Cell(index, i + 2).Style.Font.FontColor = lstColumn[i].Color;
                            rngNumbers.Cell(index, i + 2).Style.Alignment.Horizontal = lstColumn[i].Align;
                            rngNumbers.Cell(index, i + 2).Style.Alignment.WrapText = true;
                            rngNumbers.Cell(index, i + 2).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                            rngNumbers.Cell(index, i + 2).Style.Border.TopBorderColor = XLColor.Black;
                            rngNumbers.Cell(index, i + 2).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                            rngNumbers.Cell(index, i + 2).Style.Border.BottomBorderColor = XLColor.Black;
                            rngNumbers.Cell(index, i + 2).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                            rngNumbers.Cell(index, i + 2).Style.Border.LeftBorderColor = XLColor.Black;
                            rngNumbers.Cell(index, i + 2).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                            rngNumbers.Cell(index, i + 2).Style.Border.RightBorderColor = XLColor.Black;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < lstColumn.Count; i++)
                        {
                            bool is_daset = false;
                            string valCell = row[lstColumn[i].Name] == null ? " " : row[lstColumn[i].Name].ToString().Replace("<b>", "").Replace("</b>", "");
                            switch (lstColumn[i].Type)
                            {
                                case "String":
                                    break;
                                case "%":
                                    try
                                    {
                                        decimal val = Convert.ToDecimal(row[lstColumn[i].Name].ToString()) * 100;
                                        valCell = val.ToString("#,##0.00") + "%";
                                    }
                                    catch { }
                                    break;
                                case "LenLop":
                                    string len_lop = "Chưa xét";
                                    try
                                    {
                                        string tmp = row[lstColumn[i].Name].ToString().ToLower();
                                        if (tmp == "1" || tmp == "true")
                                            len_lop = "Lên lớp";
                                        else if (tmp == "0" || tmp == "false")
                                            len_lop = "Lưu ban";
                                        else len_lop = "Chưa xét";
                                    }
                                    catch { }
                                    valCell = len_lop;
                                    break;
                                case "CoKhong":
                                    string co_khong = "";
                                    try
                                    {
                                        string tmp = row[lstColumn[i].Name].ToString().ToLower();
                                        if (tmp == "1" || tmp == "true")
                                            co_khong = "Có";
                                        else if (tmp == "0" || tmp == "false")
                                            co_khong = "";
                                        else co_khong = "";
                                    }
                                    catch { }
                                    valCell = co_khong;
                                    break;
                                case "check":
                                    string check = "";
                                    try
                                    {
                                        string tmp = row[lstColumn[i].Name].ToString().ToLower();
                                        if (tmp == "1" || tmp == "true")
                                            check = "x";
                                        else check = "";
                                    }
                                    catch { }
                                    valCell = check;
                                    break;
                                case "Number":
                                    rngNumbers.Cell(index, i + 1).Style.NumberFormat.Format = "#,###";
                                    try
                                    {
                                        int valCellF = Convert.ToInt32(valCell.Replace(",", ""));
                                        rngNumbers.Cell(index, i + 1).SetValue(valCellF);
                                        is_daset = true;
                                    }
                                    catch { }
                                    break;
                                case "Decimal":
                                    if (!string.IsNullOrEmpty(lstColumn[i].NumberFormat))
                                        rngNumbers.Cell(index, i + 1).Style.NumberFormat.Format = lstColumn[i].NumberFormat;
                                    else
                                        rngNumbers.Cell(index, i + 1).Style.NumberFormat.Format = "#,##0.00";
                                    try
                                    {
                                        decimal valCellF = Convert.ToDecimal(valCell.Replace(",", ""));
                                        rngNumbers.Cell(index, i + 1).SetValue(valCellF);
                                        is_daset = true;
                                    }
                                    catch { }
                                    break;
                                case "Date":
                                    DateTime ngay1 = new DateTime();
                                    try
                                    {
                                        ngay1 = Convert.ToDateTime(row[lstColumn[i].Name].ToString());
                                        valCell = ngay1.ToString("dd/MM/yyyy");
                                    }
                                    catch { }
                                    break;
                                case "DeteTime":
                                    DateTime ngay2 = new DateTime();
                                    try
                                    {
                                        ngay2 = Convert.ToDateTime(row[lstColumn[i].Name].ToString());
                                        valCell = ngay2.ToString("dd/MM/yyyy hh:mm:ss");
                                    }
                                    catch { }
                                    break;
                            }
                            if (!is_daset)
                                rngNumbers.Cell(index, i + 1).SetValue(valCell);
                            if (row[lstColumn[i].Name].ToString().Contains("<b>"))
                                rngNumbers.Cell(index, i + 1).Style.Font.Bold = true;
                            rngNumbers.Cell(index, i + 1).Style.Font.FontColor = lstColumn[i].Color;
                            rngNumbers.Cell(index, i + 1).Style.Alignment.Horizontal = lstColumn[i].Align;
                            rngNumbers.Cell(index, i + 1).Style.Alignment.WrapText = true;
                            rngNumbers.Cell(index, i + 1).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                            rngNumbers.Cell(index, i + 1).Style.Border.TopBorderColor = XLColor.Black;
                            rngNumbers.Cell(index, i + 1).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                            rngNumbers.Cell(index, i + 1).Style.Border.BottomBorderColor = XLColor.Black;
                            rngNumbers.Cell(index, i + 1).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                            rngNumbers.Cell(index, i + 1).Style.Border.LeftBorderColor = XLColor.Black;
                            rngNumbers.Cell(index, i + 1).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                            rngNumbers.Cell(index, i + 1).Style.Border.RightBorderColor = XLColor.Black;
                        }
                    }
                    indexStart++;
                    index++;
                }
                #endregion
                workbook.SaveAs(pathNew);
                return (pathNew, newName);
            }
            catch (Exception ex)
            {
                return (null, null);
            }
        }
    }
}
