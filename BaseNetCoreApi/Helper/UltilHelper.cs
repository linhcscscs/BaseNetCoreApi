using BaseNetCoreApi.Models.Dtos;
using BaseNetCoreApi.Models.Entities;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Values;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace BaseNetCoreApi.Helper
{
    public static class UltilHelper
    {
        public static List<string> ConvertStringToListString(string stringValue)
        {
            return stringValue.Split(new char[] { ',' }).ToList();
        }
        public static string ListToStringQuery<T>(List<T> lst)
        {
            var listString = lst.Select(x => $"'{x}'").ToList();
            var lstQuery = string.Join(",", listString);
            return lstQuery;
        }
        public static byte[] StreamToByteArray(string fileName)
        {
            try
            {
                var total_stream = new byte[0];
                using (Stream input = File.Open(fileName, FileMode.Open, FileAccess.Read))
                {
                    var stream_array = new byte[0];
                    var buffer = new byte[1024];
                    int read = 0;

                    while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        stream_array = new byte[total_stream.Length + read];
                        total_stream.CopyTo(stream_array, 0);
                        Array.Copy(buffer, 0, stream_array, total_stream.Length, read);
                        total_stream = stream_array;
                    }
                }
                return total_stream;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static ReturnCode SaveTempExcelStaticFile(IFormFile file, out string filePath)
        {
            var ret = new ReturnCode();
            filePath = "";
            if (file == null || file.Length == 0)
            {
                ret = new ReturnCode(EReturnCode.NoFileUploaded);
                return ret;
            }
            var fileExtension = System.IO.Path.GetExtension(file.FileName);
            var filename = file.FileName + Guid.NewGuid().ToString();
            if (fileExtension.ToLower() != ".xls" && fileExtension.ToLower() != ".xlsx")
            {
                ret = new ReturnCode(EReturnCode.FileExtensionInvalid);
                return ret;
            }
            filePath = ConfigurationHelper.FileFolerInternalURL + "/" + filename + fileExtension;
            return SaveStaticFile(file, filePath);
        }
        public static ReturnCode SaveStaticFile(IFormFile file, string filePath)
        {
            var ret = new ReturnCode();
            try
            {
                using (var stream = System.IO.File.Create(filePath))
                {
                    file.CopyTo(stream);
                }
            }
            catch
            {
                ret = new ReturnCode(EReturnCode.InternalErrorException);
            }
            return ret;
        }
        public static PaginationResponse<Tout> ConvertToType<Tin, Tout>(this PaginationResponse<Tin> model, Func<Tin, Tout> func)
        {
            return new PaginationResponse<Tout>()
            {
                PageIndex = model.PageIndex,
                TotalItems = model.TotalItems,
                PageSize = model.PageSize,
                TotalPages = model.TotalPages,
                Data = model.Data.Select(func).ToList(),
            };
        }
        public static string GetIPAddress(this IHttpContextAccessor httpContextAccessor)
        {
            return httpContextAccessor?.HttpContext?.Connection?.RemoteIpAddress?.ToString() ?? "";
        }

        public static string GetUserAgent(this IHttpContextAccessor httpContextAccessor)
        {
            return httpContextAccessor?.HttpContext?.Request.Headers["User-Agent"].ToString() ?? "";
        }
        public static string GetURL(this IHttpContextAccessor httpContextAccessor)
        {
            return httpContextAccessor?.HttpContext?.Request.GetDisplayUrl().ToString() ?? "";
        }
        public static Dictionary<string, string> GetFieldValues(Type type)
        {
            return type.GetFields(BindingFlags.Public | BindingFlags.Static)
                      .Where(f => f.FieldType == typeof(string))
                      .ToDictionary(f => f.Name,
                                    f => (string?)f.GetValue(null) ?? "");
        }
        public static string ToNormalizeLowerRelace(this string value)
        {
            if (!string.IsNullOrEmpty(value))
                return value.Trim().ToLower().Normalize(NormalizationForm.FormKC).Replace(" ", "");
            return value;
        }
        public static int? ConvertObjectToint(object value)
        {
            if (value == null) return null;
            try
            {
                int res = Convert.ToInt32(value.ToString().Trim());
                return res;
            }
            catch
            {
                return null;
            }
        }
        public static bool ConvertIntToBool(int? value)
        {
            return (value ?? 0) == 1;
        }
        public static bool? ConvertStringToBool(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            try
            {
                if (value.ToLower() == "true" || value == "1")
                    return true;
                return false;
            }
            catch
            {
                return null;
            }
        }
        public static DateTime? ConvertStringToDate(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            try
            {
                DateTime res = Convert.ToDateTime(value);
                return res;
            }
            catch
            {
                return null;
            }
        }
        public static TimeSpan? ConvertStringToTimeSpan(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            try
            {
                TimeSpan res = TimeSpan.Parse(value);
                return res;
            }
            catch
            {
                return null;
            }
        }
        public static short? ConvertStringToShort(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            try
            {
                short res = Convert.ToInt16(value.Trim());
                return res;
            }
            catch
            {
                return null;
            }
        }
        public static Single? ConvertStringToSingle(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            try
            {
                Single res = Convert.ToSingle(value.Trim());
                return res;
            }
            catch
            {
                return null;
            }
        }
        public static Guid? ConvertStringToGuid(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            try
            {
                Guid res = Guid.Parse(value.Trim());
                return res;
            }
            catch
            {
                return null;
            }
        }
        public static Double? ConvertStringToDouble(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            try
            {
                Double res = Convert.ToDouble(value.Trim());
                return res;
            }
            catch
            {
                return null;
            }
        }
        public static float? ConvertStringToFloat(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            try
            {
                float res = float.Parse(value.Trim());
                return res;
            }
            catch
            {
                return null;
            }
        }
        public static int? ConvertStringToInt(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            try
            {
                int res = Convert.ToInt32(value.Trim());
                return res;
            }
            catch
            {
                return null;
            }
        }
        public static long? ConvertStringToLong(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            try
            {
                long res = Convert.ToInt64(value.Trim());
                return res;
            }
            catch
            {
                return null;
            }
        }
        public static decimal? ConvertStringToDecimal(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            try
            {
                decimal res = Convert.ToDecimal(value.Trim());
                return res;
            }
            catch
            {
                return null;
            }
        }
        public static DateTime? ConvertDDMMYYToDateTime(string value)
        {
            try
            {
                return DateTime.ParseExact(value, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch { }
            return null;
        }
        public static DateTime? ConvertDDMMYYhhmmssToDateTime(string value)
        {
            try
            {
                return DateTime.ParseExact(value, "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            }
            catch { }
            return null;
        }
        public static TableUploadConfigEntity getConfigValid(string DataType, int IsNull, string MinValue, string MaxValue, int MaxSize, int RequireType, string ListValue, string SchemaNameRelationship
           , string TableNameRelationship, string ColumnNameRelationship, string ColumnNameGet, string DataTypeGet, string ColumnWhere = "", string ValueWhere = "")
        {
            TableUploadConfigEntity detail = new TableUploadConfigEntity();
            detail.DataType = DataType;
            detail.IsNull = IsNull;
            detail.MinValue = MinValue;
            detail.MaxValue = MaxValue;
            detail.MaxSize = MaxSize;
            detail.RequireType = RequireType;
            detail.ListValue = ListValue;
            detail.SchemaNameRelationship = SchemaNameRelationship;
            detail.TableNameRelationship = TableNameRelationship;
            detail.ColumnNameRelationship = ColumnNameRelationship;
            detail.ColumnNameGet = ColumnNameGet;
            detail.DataTypeGet = DataTypeGet;
            detail.ColumnWhere = ColumnWhere;
            detail.ValueWhere = ValueWhere;
            return detail;
        }
        public static string ToNormalize(this string value)
        {
            if (!string.IsNullOrEmpty(value))
                return value.Trim().Normalize(NormalizationForm.FormKC);
            return value;
        }
    }
}
