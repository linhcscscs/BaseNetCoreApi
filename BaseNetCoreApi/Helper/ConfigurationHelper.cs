using Microsoft.AspNetCore.Hosting;

namespace BaseNetCoreApi.Helper
{
    public static class ConfigurationHelper
    {
        public static IConfiguration Configuration;
        public static IWebHostEnvironment WebHostEnvironment;

        public static string GetConnectionStringByName(string connectionStringName)
        {
            return Configuration.GetConnectionString(connectionStringName) ?? "";
        }
        public static string GetConfigByName(string name)
        {
            return Configuration[name] ?? "";
        }
        public static int NamHoc
        {
            get
            {
                var ma_nam_hoc = 2022;
                if (int.TryParse(GetConfigByName("AppSettings:nam_hoc"), out var ma_nam_hoc_temp))
                {
                    ma_nam_hoc = ma_nam_hoc_temp;
                }
                return ma_nam_hoc;
            }
        }
        public static int UploadFileLimit
        {
            get
            {
                var uploadFileLimit = int.MaxValue;
                if (int.TryParse(GetConfigByName("AppSettings:UploadFileLimit"), out var uploadFileLimitTemp))
                {
                    uploadFileLimit = uploadFileLimitTemp;
                }
                return uploadFileLimit;
            }
        }
        public static string ServerMapPath
        {
            get
            {
                return WebHostEnvironment.ContentRootPath;
            }
        }
        public static string FileFolerInternalURL
        {
            get
            {
                return WebHostEnvironment.ContentRootPath + GetConfigByName("AppSettings:FileFolerInternal");
            }
        }
        public static string FileFolerStaticURL
        {
            get
            {
                return WebHostEnvironment.ContentRootPath + GetConfigByName("AppSettings:FileFolerStatic");
            }
        }

        public static double TempFileExpInMinutes
        {
            get
            {
                double tempFileExpInMinutes = 60;
                if (double.TryParse(GetConfigByName("AppSettings:TempFileExpInMinutes"), out var tempFileExpInMinutesTemp))
                {
                    tempFileExpInMinutes = tempFileExpInMinutesTemp;
                }
                return tempFileExpInMinutes;
            }
        }

        public static class TimedService
        {
            public static string TIMED_SERVICE_CONFIG_NAME = "AppSettings:TimedService:";
            public static string CLEAR_EXPERIED_REFRESHTOKEN_CONFIG_NAME = "ClearExpRefeshToken";
            public static string CLEAR_TEMP_FILE_CONFIG_NAME = "ClearTempFile";
        }

        public static int MaxPageSize
        {
            get
            {
                int maxPageSize = 200;
                if (int.TryParse(GetConfigByName("AppSettings:MaxPageSize"), out var maxPageSizeTemp))
                {
                    maxPageSize = maxPageSizeTemp;
                }
                return maxPageSize;
            }
        }
        public static string CookieSecret
        {
            get
            {
                return GetConfigByName("AppSettings:CookieSecret");
            }
        }
        public static string QiAuth
        {
            get
            {
                return GetConfigByName("AppSettings:QiAuth");
            }
        }

        public static string API_CSDL(string name)
        {
            return GetConfigByName($"API_CSDL:{name}");
        }

        public static string MONGODB_NAME
        {
            get
            {
                return GetConfigByName("AppSettings:MONGODB_NAME");
            }
        }
    }
}
