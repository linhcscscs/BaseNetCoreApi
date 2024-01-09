using BaseNetCoreApi.Models.Entities;
using BaseNetCoreApi.Values;
using System.Globalization;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace BaseNetCoreApi.Helper
{
    public static class ValidateHelper
    {
        public static bool ValidateObject(TableUploadConfigEntity columnDetail, string value, out object val, out string Error, out string ErrorDes)
        {
            val = null;
            Error = SysTableErrorCode.ThanhCong;
            ErrorDes = SysTableErrorCode.ThanhCong_Des;
            switch (columnDetail.DataType)
            {
                case "String":
                    return ValString(columnDetail, value, out val, out Error, out ErrorDes);
                case "Boolean":
                    return ValBool(columnDetail, value, out val, out Error, out ErrorDes);
                case "Date":
                    return ValDate(columnDetail, value, out val, out Error, out ErrorDes);
                case "DateTime":
                    return ValDateTime(columnDetail, value, out val, out Error, out ErrorDes);
                case "TimeSpan":
                    return ValDate(columnDetail, value, out val, out Error, out ErrorDes);
                case "Long":
                    return ValLong(columnDetail, value, out val, out Error, out ErrorDes);
                case "Bigint":
                    return ValBigint(columnDetail, value, out val, out Error, out ErrorDes);
                case "Decimal":
                    return ValDecimal(columnDetail, value, out val, out Error, out ErrorDes);
                case "Double":
                    return ValDouble(columnDetail, value, out val, out Error, out ErrorDes);
                case "Float":
                    return ValFloat(columnDetail, value, out val, out Error, out ErrorDes);
                case "Int32":
                    return ValInt(columnDetail, value, out val, out Error, out ErrorDes);
                case "Int16":
                    return ValShort(columnDetail, value, out val, out Error, out ErrorDes);
                case "Single":
                    return ValSingle(columnDetail, value, out val, out Error, out ErrorDes);
                case "Guid":
                    return ValString(columnDetail, value, out val, out Error, out ErrorDes);
                case "Email":
                    return ValEmail(columnDetail, value, out val, out Error, out ErrorDes);
                case "Phone":
                    return ValPhone(columnDetail, value, out val, out Error, out ErrorDes);
                default:
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
            }
        }
        public static bool ValString(TableUploadConfigEntity columnDetail, string value, out object val, out string Error, out string ErrorDes)
        {
            val = !string.IsNullOrEmpty(value) ? value.Trim() : null;
            Error = SysTableErrorCode.ThanhCong;
            ErrorDes = SysTableErrorCode.ThanhCong_Des;

            if (columnDetail.IsNull == 1 && string.IsNullOrEmpty(value))
            {
                Error = SysTableErrorCode.BatBuoc;
                ErrorDes = SysTableErrorCode.BatBuoc_Des;
                return false;
            }
            if (columnDetail.IsNull != 1 && string.IsNullOrEmpty(value))
            {
                val = null;
                return true;
            }
            if (val.ToString().ToArray().Length > columnDetail.MaxSize && columnDetail.MaxSize > 0)
            {
                Error = SysTableErrorCode.VuotQuaKichThuoc;
                ErrorDes = SysTableErrorCode.VuotQuaKichThuoc_Des;
                return false;
            }
            #region Valid in list value
            if (columnDetail.RequireType == 1)
            {
                string strListValue = columnDetail.ListValue.Replace("@", "*acong*").Replace("||", "@").Replace("|", "").Replace("@", "|").Replace("*acong*", "@");
                List<string> lstValue = strListValue.Split('|').ToList();
                if (lstValue.Count(x => x.ToNormalizeLowerRelace() == value.ToNormalizeLowerRelace()) == 0)
                {
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
                }
            }
            #endregion
            #region Valid in Danh mục
            else if (columnDetail.RequireType == 2)
            {
                return ValDanhMuc(columnDetail, value, out val, out Error, out ErrorDes);
            }
            #endregion
            return true;
        }
        public static bool ValInt(TableUploadConfigEntity columnDetail, string value, out object val, out string Error, out string ErrorDes)
        {
            val = !string.IsNullOrEmpty(value) ? value.Trim() : null;
            Error = SysTableErrorCode.ThanhCong;
            ErrorDes = SysTableErrorCode.ThanhCong_Des;

            if (columnDetail.IsNull == 1 && string.IsNullOrEmpty(value))
            {
                Error = SysTableErrorCode.BatBuoc;
                ErrorDes = SysTableErrorCode.BatBuoc_Des;
                return false;
            }
            if (columnDetail.IsNull != 1 && string.IsNullOrEmpty(value))
            {
                val = null;
                return true;
            }
            if (value.ToArray().Length > columnDetail.MaxSize && columnDetail.MaxSize > 0)
            {
                Error = SysTableErrorCode.VuotQuaKichThuoc;
                ErrorDes = SysTableErrorCode.VuotQuaKichThuoc_Des;
                return false;
            }
            try
            {

                val = Convert.ToInt32(value);
                int? min = UltilHelper.ConvertStringToInt(columnDetail.MinValue);
                int? max = UltilHelper.ConvertStringToInt(columnDetail.MaxValue);
                if ((min != null && (int)val < min) || (max != null && (int)val > max))
                {
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
                }
            }
            catch
            {

                Error = SysTableErrorCode.SaiDinhDang;
                ErrorDes = SysTableErrorCode.SaiDinhDang_Des;
                return false;
            }
            #region Valid in list value
            if (columnDetail.RequireType == 1)
            {
                string strListValue = columnDetail.ListValue.Replace("@", "*acong*").Replace("||", "@").Replace("|", "").Replace("@", "|").Replace("*acong*", "@");
                List<string> lstValue = strListValue.Split('|').ToList();
                if (lstValue.Count(x => x.ToNormalizeLowerRelace() == value.ToNormalizeLowerRelace()) == 0)
                {
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
                }
            }
            #endregion
            #region Valid in Danh mục
            else if (columnDetail.RequireType == 2)
            {
                return ValDanhMuc(columnDetail, value, out val, out Error, out ErrorDes);
            }
            #endregion
            return true;
        }
        public static bool ValSingle(TableUploadConfigEntity columnDetail, string value, out object val, out string Error, out string ErrorDes)
        {
            val = !string.IsNullOrEmpty(value) ? value.Trim() : null;
            Error = SysTableErrorCode.ThanhCong;
            ErrorDes = SysTableErrorCode.ThanhCong_Des;

            if (columnDetail.IsNull == 1 && string.IsNullOrEmpty(value))
            {
                Error = SysTableErrorCode.BatBuoc;
                ErrorDes = SysTableErrorCode.BatBuoc_Des;
                return false;
            }
            if (columnDetail.IsNull != 1 && string.IsNullOrEmpty(value))
            {
                val = null;
                return true;
            }
            if (value.ToArray().Length > columnDetail.MaxSize && columnDetail.MaxSize > 0)
            {
                Error = SysTableErrorCode.VuotQuaKichThuoc;
                ErrorDes = SysTableErrorCode.VuotQuaKichThuoc_Des;
                return false;
            }
            try
            {

                val = Convert.ToSingle(value);
                Single? min = UltilHelper.ConvertStringToSingle(columnDetail.MinValue);
                Single? max = UltilHelper.ConvertStringToSingle(columnDetail.MaxValue);
                if ((min != null && (Single)val < min) || (max != null && (Single)val > max))
                {
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
                }
            }
            catch
            {

                Error = SysTableErrorCode.SaiDinhDang;
                ErrorDes = SysTableErrorCode.SaiDinhDang_Des;
                return false;
            }
            #region Valid in list value
            if (columnDetail.RequireType == 1)
            {
                string strListValue = columnDetail.ListValue.Replace("@", "*acong*").Replace("||", "@").Replace("|", "").Replace("@", "|").Replace("*acong*", "@");
                List<string> lstValue = strListValue.Split('|').ToList();
                if (lstValue.Count(x => x.ToNormalizeLowerRelace() == value.ToNormalizeLowerRelace()) == 0)
                {
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
                }
            }
            #endregion
            #region Valid in Danh mục
            else if (columnDetail.RequireType == 2)
            {
                return ValDanhMuc(columnDetail, value, out val, out Error, out ErrorDes);
            }
            #endregion
            return true;
        }
        public static bool ValBool(TableUploadConfigEntity columnDetail, string value, out object val, out string Error, out string ErrorDes)
        {
            val = !string.IsNullOrEmpty(value) ? value.Trim() : null;
            Error = SysTableErrorCode.ThanhCong;
            ErrorDes = SysTableErrorCode.ThanhCong_Des;

            if (columnDetail.IsNull == 1 && string.IsNullOrEmpty(value))
            {
                Error = SysTableErrorCode.BatBuoc;
                ErrorDes = SysTableErrorCode.BatBuoc_Des;
                return false;
            }
            if (columnDetail.IsNull != 1 && string.IsNullOrEmpty(value))
            {
                val = null;
                return true;
            }
            try
            {

                if (value.ToLower() == "true" || value == "1")
                    val = true;
                else if (value.ToLower() == "false" || value == "0")
                    val = false;
                else
                {
                    Error = SysTableErrorCode.SaiDinhDang;
                    ErrorDes = SysTableErrorCode.SaiDinhDang_Des;
                    return false;
                }
            }
            catch
            {

                Error = SysTableErrorCode.SaiDinhDang;
                ErrorDes = SysTableErrorCode.SaiDinhDang_Des;
                return false;
            }

            return true;
        }
        public static bool ValDecimal(TableUploadConfigEntity columnDetail, string value, out object val, out string Error, out string ErrorDes)
        {
            val = !string.IsNullOrEmpty(value) ? value.Trim() : null;
            Error = SysTableErrorCode.ThanhCong;
            ErrorDes = SysTableErrorCode.ThanhCong_Des;

            if (columnDetail.IsNull == 1 && string.IsNullOrEmpty(value))
            {
                Error = SysTableErrorCode.BatBuoc;
                ErrorDes = SysTableErrorCode.BatBuoc_Des;
                return false;
            }
            if (columnDetail.IsNull != 1 && string.IsNullOrEmpty(value))
            {
                val = null;
                return true;
            }
            if (value.ToArray().Length > columnDetail.MaxSize && columnDetail.MaxSize > 0)
            {
                Error = SysTableErrorCode.VuotQuaKichThuoc;
                ErrorDes = SysTableErrorCode.VuotQuaKichThuoc_Des;
                return false;
            }
            try
            {
                if (value.Contains(","))
                {
                    Error = SysTableErrorCode.SaiDinhDang;
                    ErrorDes = SysTableErrorCode.SaiDinhDang_Des;
                    return false;
                }
                val = Convert.ToDecimal(value);
                decimal? min = UltilHelper.ConvertStringToDecimal(columnDetail.MinValue);
                decimal? max = UltilHelper.ConvertStringToDecimal(columnDetail.MaxValue);
                if ((min != null && (Decimal)val < min) || (max != null && (Decimal)val > max))
                {
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
                }
            }
            catch
            {
                Error = SysTableErrorCode.SaiDinhDang;
                ErrorDes = SysTableErrorCode.SaiDinhDang_Des;
                return false;
            }
            #region Valid in list value
            if (columnDetail.RequireType == 1)
            {
                string strListValue = columnDetail.ListValue.Replace("@", "*acong*").Replace("||", "@").Replace("|", "").Replace("@", "|").Replace("*acong*", "@");
                List<string> lstValue = strListValue.Split('|').ToList();
                if (lstValue.Count(x => x.ToNormalizeLowerRelace() == value.ToNormalizeLowerRelace()) == 0)
                {
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
                }
            }
            #endregion
            #region Valid in Danh mục
            else if (columnDetail.RequireType == 2)
            {
                return ValDanhMuc(columnDetail, value, out val, out Error, out ErrorDes);
            }
            #endregion
            return true;
        }
        public static bool ValDouble(TableUploadConfigEntity columnDetail, string value, out object val, out string Error, out string ErrorDes)
        {
            val = !string.IsNullOrEmpty(value) ? value.Trim() : null;
            Error = SysTableErrorCode.ThanhCong;
            ErrorDes = SysTableErrorCode.ThanhCong_Des;

            if (columnDetail.IsNull == 1 && string.IsNullOrEmpty(value))
            {
                Error = SysTableErrorCode.BatBuoc;
                ErrorDes = SysTableErrorCode.BatBuoc_Des;
                return false;
            }
            if (columnDetail.IsNull != 1 && string.IsNullOrEmpty(value))
            {
                val = null;
                return true;
            }
            if (value.ToArray().Length > columnDetail.MaxSize && columnDetail.MaxSize > 0)
            {
                Error = SysTableErrorCode.VuotQuaKichThuoc;
                ErrorDes = SysTableErrorCode.VuotQuaKichThuoc_Des;
                return false;
            }
            try
            {
                if (value.Contains(","))
                {
                    Error = SysTableErrorCode.SaiDinhDang;
                    ErrorDes = SysTableErrorCode.SaiDinhDang_Des;
                    return false;
                }
                val = Convert.ToDouble(value);
                double? min = UltilHelper.ConvertStringToDouble(columnDetail.MinValue);
                double? max = UltilHelper.ConvertStringToDouble(columnDetail.MaxValue);
                if ((min != null && (double)val < min) || (max != null && (double)val > max))
                {
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
                }
            }
            catch
            {
                Error = SysTableErrorCode.SaiDinhDang;
                ErrorDes = SysTableErrorCode.SaiDinhDang_Des;
                return false;
            }
            #region Valid in list value
            if (columnDetail.RequireType == 1)
            {
                string strListValue = columnDetail.ListValue.Replace("@", "*acong*").Replace("||", "@").Replace("|", "").Replace("@", "|").Replace("*acong*", "@");
                List<string> lstValue = strListValue.Split('|').ToList();
                if (lstValue.Count(x => x.ToNormalizeLowerRelace() == value.ToNormalizeLowerRelace()) == 0)
                {
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
                }
            }
            #endregion
            #region Valid in Danh mục
            else if (columnDetail.RequireType == 2)
            {
                return ValDanhMuc(columnDetail, value, out val, out Error, out ErrorDes);
            }
            #endregion
            return true;
        }
        public static bool ValFloat(TableUploadConfigEntity columnDetail, string value, out object val, out string Error, out string ErrorDes)
        {
            val = !string.IsNullOrEmpty(value) ? value.Trim() : null;
            Error = SysTableErrorCode.ThanhCong;
            ErrorDes = SysTableErrorCode.ThanhCong_Des;

            if (columnDetail.IsNull == 1 && string.IsNullOrEmpty(value))
            {
                Error = SysTableErrorCode.BatBuoc;
                ErrorDes = SysTableErrorCode.BatBuoc_Des;
                return false;
            }
            if (columnDetail.IsNull != 1 && string.IsNullOrEmpty(value))
            {
                val = null;
                return true;
            }
            if (value.ToArray().Length > columnDetail.MaxSize && columnDetail.MaxSize > 0)
            {
                Error = SysTableErrorCode.VuotQuaKichThuoc;
                ErrorDes = SysTableErrorCode.VuotQuaKichThuoc_Des;
                return false;
            }
            try
            {
                if (value.Contains(","))
                {
                    Error = SysTableErrorCode.SaiDinhDang;
                    ErrorDes = SysTableErrorCode.SaiDinhDang_Des;
                    return false;
                }
                val = float.Parse(value);
                float? min = UltilHelper.ConvertStringToFloat(columnDetail.MinValue);
                float? max = UltilHelper.ConvertStringToFloat(columnDetail.MaxValue);
                if ((min != null && (float)val < min) || (max != null && (float)val > max))
                {
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
                }
            }
            catch
            {
                Error = SysTableErrorCode.SaiDinhDang;
                ErrorDes = SysTableErrorCode.SaiDinhDang_Des;
                return false;
            }
            #region Valid in list value
            if (columnDetail.RequireType == 1)
            {
                string strListValue = columnDetail.ListValue.Replace("@", "*acong*").Replace("||", "@").Replace("|", "").Replace("@", "|").Replace("*acong*", "@");
                List<string> lstValue = strListValue.Split('|').ToList();
                if (lstValue.Count(x => x.ToNormalizeLowerRelace() == value.ToNormalizeLowerRelace()) == 0)
                {
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
                }
            }
            #endregion
            #region Valid in Danh mục
            else if (columnDetail.RequireType == 2)
            {
                return ValDanhMuc(columnDetail, value, out val, out Error, out ErrorDes);
            }
            #endregion
            return true;
        }
        public static bool ValShort(TableUploadConfigEntity columnDetail, string value, out object val, out string Error, out string ErrorDes)
        {
            val = !string.IsNullOrEmpty(value) ? value.Trim() : null;
            Error = SysTableErrorCode.ThanhCong;
            ErrorDes = SysTableErrorCode.ThanhCong_Des;

            if (columnDetail.IsNull == 1 && string.IsNullOrEmpty(value))
            {
                Error = SysTableErrorCode.BatBuoc;
                ErrorDes = SysTableErrorCode.BatBuoc_Des;
                return false;
            }
            if (columnDetail.IsNull != 1 && string.IsNullOrEmpty(value))
            {
                val = null;
                return true;
            }
            if (value.ToArray().Length > columnDetail.MaxSize && columnDetail.MaxSize > 0)
            {
                Error = SysTableErrorCode.VuotQuaKichThuoc;
                ErrorDes = SysTableErrorCode.VuotQuaKichThuoc_Des;
                return false;
            }
            try
            {
                if (value.Contains(","))
                {
                    Error = SysTableErrorCode.SaiDinhDang;
                    ErrorDes = SysTableErrorCode.SaiDinhDang_Des;
                    return false;
                }
                val = Convert.ToInt16(value);
                short? min = UltilHelper.ConvertStringToShort(columnDetail.MinValue);
                short? max = UltilHelper.ConvertStringToShort(columnDetail.MaxValue);
                if ((min != null && (short)val < min) || (max != null && (short)val > max))
                {
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
                }
            }
            catch
            {
                Error = SysTableErrorCode.SaiDinhDang;
                ErrorDes = SysTableErrorCode.SaiDinhDang_Des;
                return false;
            }
            #region Valid in list value
            if (columnDetail.RequireType == 1)
            {
                string strListValue = columnDetail.ListValue.Replace("@", "*acong*").Replace("||", "@").Replace("|", "").Replace("@", "|").Replace("*acong*", "@");
                List<string> lstValue = strListValue.Split('|').ToList();
                if (lstValue.Count(x => x.ToNormalizeLowerRelace() == value.ToNormalizeLowerRelace()) == 0)
                {
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
                }
            }
            #endregion
            #region Valid in Danh mục
            else if (columnDetail.RequireType == 2)
            {
                return ValDanhMuc(columnDetail, value, out val, out Error, out ErrorDes);
            }
            #endregion
            return true;
        }
        public static bool ValLong(TableUploadConfigEntity columnDetail, string value, out object val, out string Error, out string ErrorDes)
        {
            val = !string.IsNullOrEmpty(value) ? value.Trim() : null;
            Error = SysTableErrorCode.ThanhCong;
            ErrorDes = SysTableErrorCode.ThanhCong_Des;

            if (columnDetail.IsNull == 1 && string.IsNullOrEmpty(value))
            {
                Error = SysTableErrorCode.BatBuoc;
                ErrorDes = SysTableErrorCode.BatBuoc_Des;
                return false;
            }
            if (columnDetail.IsNull != 1 && string.IsNullOrEmpty(value))
            {
                val = null;
                return true;
            }
            if (value.ToArray().Length > columnDetail.MaxSize && columnDetail.MaxSize > 0)
            {
                Error = SysTableErrorCode.VuotQuaKichThuoc;
                ErrorDes = SysTableErrorCode.VuotQuaKichThuoc_Des;
                return false;
            }
            try
            {
                if (value.Contains(","))
                {
                    Error = SysTableErrorCode.SaiDinhDang;
                    ErrorDes = SysTableErrorCode.SaiDinhDang_Des;
                    return false;
                }
                val = Convert.ToInt64(value);
                long? min = UltilHelper.ConvertStringToLong(columnDetail.MinValue);
                long? max = UltilHelper.ConvertStringToLong(columnDetail.MaxValue);
                if ((min != null && (long)val < min) || (max != null && (long)val > max))
                {
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
                }
            }
            catch
            {
                Error = SysTableErrorCode.SaiDinhDang;
                ErrorDes = SysTableErrorCode.SaiDinhDang_Des;
                return false;
            }
            #region Valid in list value
            if (columnDetail.RequireType == 1)
            {
                string strListValue = columnDetail.ListValue.Replace("@", "*acong*").Replace("||", "@").Replace("|", "").Replace("@", "|").Replace("*acong*", "@");
                List<string> lstValue = strListValue.Split('|').ToList();
                if (lstValue.Count(x => x.ToNormalizeLowerRelace() == value.ToNormalizeLowerRelace()) == 0)
                {
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
                }
            }
            #endregion
            #region Valid in Danh mục
            else if (columnDetail.RequireType == 2)
            {
                return ValDanhMuc(columnDetail, value, out val, out Error, out ErrorDes);
            }
            #endregion
            return true;
        }
        public static bool ValBigint(TableUploadConfigEntity columnDetail, string value, out object val, out string Error, out string ErrorDes)
        {
            val = !string.IsNullOrEmpty(value) ? value.Trim() : null;
            Error = SysTableErrorCode.ThanhCong;
            ErrorDes = SysTableErrorCode.ThanhCong_Des;

            if (columnDetail.IsNull == 1 && string.IsNullOrEmpty(value))
            {
                Error = SysTableErrorCode.BatBuoc;
                ErrorDes = SysTableErrorCode.BatBuoc_Des;
                return false;
            }
            if (columnDetail.IsNull != 1 && string.IsNullOrEmpty(value))
            {
                val = null;
                return true;
            }
            if (value.ToArray().Length > columnDetail.MaxSize && columnDetail.MaxSize > 0)
            {
                Error = SysTableErrorCode.VuotQuaKichThuoc;
                ErrorDes = SysTableErrorCode.VuotQuaKichThuoc_Des;
                return false;
            }
            try
            {
                if (value.Contains(","))
                {
                    Error = SysTableErrorCode.SaiDinhDang;
                    ErrorDes = SysTableErrorCode.SaiDinhDang_Des;
                    return false;
                }
                val = Convert.ToInt64(value);
                long? min = UltilHelper.ConvertStringToLong(columnDetail.MinValue);
                long? max = UltilHelper.ConvertStringToLong(columnDetail.MaxValue);
                if ((min != null && (long)val < min) || (max != null && (long)val > max))
                {
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
                }
            }
            catch
            {
                Error = SysTableErrorCode.SaiDinhDang;
                ErrorDes = SysTableErrorCode.SaiDinhDang_Des;
                return false;
            }
            #region Valid in list value
            if (columnDetail.RequireType == 1)
            {
                string strListValue = columnDetail.ListValue.Replace("@", "*acong*").Replace("||", "@").Replace("|", "").Replace("@", "|").Replace("*acong*", "@");
                List<string> lstValue = strListValue.Split('|').ToList();
                if (lstValue.Count(x => x.ToNormalizeLowerRelace() == value.ToNormalizeLowerRelace()) == 0)
                {
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
                }
            }
            #endregion
            #region Valid in Danh mục
            else if (columnDetail.RequireType == 2)
            {
                return ValDanhMuc(columnDetail, value, out val, out Error, out ErrorDes);
            }
            #endregion
            return true;
        }
        public static bool ValDate(TableUploadConfigEntity columnDetail, string value, out object val, out string Error, out string ErrorDes)
        {
            val = !string.IsNullOrEmpty(value) ? value.Trim() : null;
            Error = SysTableErrorCode.ThanhCong;
            ErrorDes = SysTableErrorCode.ThanhCong_Des;

            if (columnDetail.IsNull == 1 && string.IsNullOrEmpty(value))
            {
                Error = SysTableErrorCode.BatBuoc;
                ErrorDes = SysTableErrorCode.BatBuoc_Des;
                return false;
            }
            if (columnDetail.IsNull != 1 && string.IsNullOrEmpty(value))
            {
                val = null;
                return true;
            }
            try
            {
                DateTime? dttmp = null;
                try
                {
                    if (!value.Contains("/"))
                        dttmp = DateTime.Parse(value);
                }
                catch { }
                DateTime dt = new DateTime();
                if (dttmp != null)
                    dt = dttmp.Value;
                else dt = DateTime.ParseExact(value, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime? min = UltilHelper.ConvertDDMMYYToDateTime(columnDetail.MinValue);
                DateTime? max = UltilHelper.ConvertDDMMYYToDateTime(columnDetail.MaxValue);
                val = dt;
                if ((min != null && dt.CompareTo(min) < 0) || (max != null && dt.CompareTo(max) < 0))
                {
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
                }
            }
            catch
            {
                Error = SysTableErrorCode.SaiDinhDang;
                ErrorDes = SysTableErrorCode.SaiDinhDang_Des;
                return false;
            }

            return true;
        }
        public static bool ValTimeSpan(TableUploadConfigEntity columnDetail, string value, out object val, out string Error, out string ErrorDes)
        {
            val = !string.IsNullOrEmpty(value) ? value.Trim() : null;
            Error = SysTableErrorCode.ThanhCong;
            ErrorDes = SysTableErrorCode.ThanhCong_Des;

            if (columnDetail.IsNull == 1 && string.IsNullOrEmpty(value))
            {
                Error = SysTableErrorCode.BatBuoc;
                ErrorDes = SysTableErrorCode.BatBuoc_Des;
                return false;
            }
            if (columnDetail.IsNull != 1 && string.IsNullOrEmpty(value))
            {
                val = null;
                return true;
            }
            if (value.ToArray().Length > columnDetail.MaxSize && columnDetail.MaxSize > 0)
            {
                Error = SysTableErrorCode.VuotQuaKichThuoc;
                ErrorDes = SysTableErrorCode.VuotQuaKichThuoc_Des;
                return false;
            }
            try
            {
                if (value.Contains(","))
                {
                    Error = SysTableErrorCode.SaiDinhDang;
                    ErrorDes = SysTableErrorCode.SaiDinhDang_Des;
                    return false;
                }
                val = TimeSpan.Parse(value);
                TimeSpan? min = UltilHelper.ConvertStringToTimeSpan(columnDetail.MinValue);
                TimeSpan? max = UltilHelper.ConvertStringToTimeSpan(columnDetail.MaxValue);
                if ((min != null && (TimeSpan)val < min) || (max != null && (TimeSpan)val > max))
                {
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
                }
            }
            catch
            {
                Error = SysTableErrorCode.SaiDinhDang;
                ErrorDes = SysTableErrorCode.SaiDinhDang_Des;
                return false;
            }

            return true;
        }
        public static bool ValDateTime(TableUploadConfigEntity columnDetail, string value, out object val, out string Error, out string ErrorDes)
        {
            val = !string.IsNullOrEmpty(value) ? value.Trim() : null;
            Error = SysTableErrorCode.ThanhCong;
            ErrorDes = SysTableErrorCode.ThanhCong_Des;

            if (columnDetail.IsNull == 1 && string.IsNullOrEmpty(value))
            {
                Error = SysTableErrorCode.BatBuoc;
                ErrorDes = SysTableErrorCode.BatBuoc_Des;
                return false;
            }
            if (columnDetail.IsNull != 1 && string.IsNullOrEmpty(value))
            {
                val = null;
                return true;
            }
            try
            {
                DateTime? dttmp = null;
                try
                {
                    if (!value.Contains("/"))
                        dttmp = DateTime.Parse(value);
                }
                catch { }
                DateTime dt = new DateTime();
                if (dttmp != null)
                    dt = dttmp.Value;
                else dt = DateTime.ParseExact(value, "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                DateTime? min = UltilHelper.ConvertDDMMYYhhmmssToDateTime(columnDetail.MinValue);
                DateTime? max = UltilHelper.ConvertDDMMYYhhmmssToDateTime(columnDetail.MaxValue);
                val = dt;
                if ((min != null && dt.CompareTo(min) < 0) || (max != null && dt.CompareTo(max) < 0))
                {
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
                }
            }
            catch
            {
                Error = SysTableErrorCode.SaiDinhDang;
                ErrorDes = SysTableErrorCode.SaiDinhDang_Des;
                return false;
            }

            return true;
        }
        public static bool ValDanhMuc(TableUploadConfigEntity columnDetail, string value, out object val, out string Error, out string ErrorDes)
        {
            val = !string.IsNullOrEmpty(value) ? value.Trim() : null;
            Error = SysTableErrorCode.ThanhCong;
            ErrorDes = SysTableErrorCode.ThanhCong_Des;
            try
            {
                string strConn = SqlHelper.getConnectString(ConfigurationHelper.SQL_SERVER, columnDetail.SchemaNameRelationship, ConfigurationHelper.SQL_USER, ConfigurationHelper.SQL_PASSWORD);
                List<DanhMucEntity> lstData = new List<DanhMucEntity>();
                lstData = SqlHelper.getDanhMuc(strConn, columnDetail.TableNameRelationship, columnDetail.ColumnNameGet, columnDetail.ColumnNameRelationship, columnDetail.ColumnWhere, columnDetail.ValueWhere);
                DanhMucEntity detail = lstData.Where(x => x.Text.ToNormalizeLowerRelace() == value.ToNormalizeLowerRelace()).FirstOrDefault();
                if (detail != null)
                {
                    switch (columnDetail.DataTypeGet)
                    {
                        case "String":
                            val = detail.Value;
                            break;
                        case "Boolean":
                            val = UltilHelper.ConvertStringToBool(detail.Value);
                            break;
                        case "Date":
                            val = DateTime.Parse(detail.Value);
                            break;
                        case "DateTime":
                            val = DateTime.Parse(detail.Value);
                            break;
                        case "TimeSpan":
                            val = TimeSpan.Parse(detail.Value);
                            break;
                        case "Long":
                            val = long.Parse(detail.Value);
                            break;
                        case "Bigint":
                            val = long.Parse(detail.Value);
                            break;
                        case "Decimal":
                            val = decimal.Parse(detail.Value);
                            break;
                        case "Double":
                            val = Double.Parse(detail.Value);
                            break;
                        case "Float":
                            val = float.Parse(detail.Value);
                            break;
                        case "Int32":
                            val = Int32.Parse(detail.Value);
                            break;
                        case "Int16":
                            val = Int32.Parse(detail.Value);
                            break;
                        case "Single":
                            val = Single.Parse(detail.Value);
                            break;
                        case "Guid":
                            val = Guid.Parse(detail.Value);
                            break;
                        default:
                            Error = SysTableErrorCode.GiaTriKhongHopLe;
                            ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                            return false;
                    }
                }
                else
                {
                    Error = SysTableErrorCode.GiaTriKhongTonTaiTrongDanhMuc;
                    ErrorDes = SysTableErrorCode.GiaTriKhongTonTaiTrongDanhMuc_Des;
                    return false;
                }
            }
            catch
            {
                Error = SysTableErrorCode.SaiDinhDang;
                ErrorDes = SysTableErrorCode.SaiDinhDang_Des;
                return false;
            }
            return true;
        }
        public static bool ValEmail(TableUploadConfigEntity columnDetail, string value, out object val, out string Error, out string ErrorDes)
        {
            val = !string.IsNullOrEmpty(value) ? value.Trim() : null;
            Error = SysTableErrorCode.ThanhCong;
            ErrorDes = SysTableErrorCode.ThanhCong_Des;

            if (columnDetail.IsNull == 1 && string.IsNullOrEmpty(value))
            {
                Error = SysTableErrorCode.BatBuoc;
                ErrorDes = SysTableErrorCode.BatBuoc_Des;
                return false;
            }
            if (columnDetail.IsNull != 1 && string.IsNullOrEmpty(value))
            {
                val = null;
                return true;
            }
            if (val.ToString().ToArray().Length > columnDetail.MaxSize && columnDetail.MaxSize > 0)
            {
                Error = SysTableErrorCode.VuotQuaKichThuoc;
                ErrorDes = SysTableErrorCode.VuotQuaKichThuoc_Des;
                return false;
            }
            #region Valid in list value
            if (columnDetail.RequireType == 1)
            {
                try
                {
                    MailAddress valEmal = new MailAddress(val.ToString());
                }
                catch (FormatException)
                {
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
                }
            }
            #endregion
            #region Valid in Danh mục
            else if (columnDetail.RequireType == 2)
            {
                return ValDanhMuc(columnDetail, value, out val, out Error, out ErrorDes);
            }
            #endregion
            return true;
        }
        public static bool ValPhone(TableUploadConfigEntity columnDetail, string value, out object val, out string Error, out string ErrorDes)
        {
            val = !string.IsNullOrEmpty(value) ? value.Trim() : null;
            Error = SysTableErrorCode.ThanhCong;
            ErrorDes = SysTableErrorCode.ThanhCong_Des;

            if (columnDetail.IsNull == 1 && string.IsNullOrEmpty(value))
            {
                Error = SysTableErrorCode.BatBuoc;
                ErrorDes = SysTableErrorCode.BatBuoc_Des;
                return false;
            }
            if (columnDetail.IsNull != 1 && string.IsNullOrEmpty(value))
            {
                val = null;
                return true;
            }
            if (value.ToArray().Length > columnDetail.MaxSize && columnDetail.MaxSize > 0)
            {
                Error = SysTableErrorCode.VuotQuaKichThuoc;
                ErrorDes = SysTableErrorCode.VuotQuaKichThuoc_Des;
                return false;
            }
            if (columnDetail.RequireType == 1)
            {
                Regex regex = new Regex(@"^0[1-9]\d{8}$");
                Match match = regex.Match(value.Trim());
                if (!match.Success)
                {
                    Error = SysTableErrorCode.GiaTriKhongHopLe;
                    ErrorDes = SysTableErrorCode.GiaTriKhongHopLe_Des;
                    return false;
                }
            }
            #region Valid in Danh mục
            else if (columnDetail.RequireType == 2)
            {
                return ValDanhMuc(columnDetail, value, out val, out Error, out ErrorDes);
            }
            #endregion
            return true;
        }
    }
}
