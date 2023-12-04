﻿namespace BaseNetCoreApi.Helper
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

        public static bool IsSessionAuth
        {
            get
            {
                var isSessionAuth = false;
                if (bool.TryParse(GetConfigByName("AppSettings:IsSessionAuth"), out var isSessionAuthTemp))
                {
                    isSessionAuth = isSessionAuthTemp;
                }
                return isSessionAuth;
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
                if (double.TryParse(GetConfigByName("AppSettings:IsSessionAuth"), out var tempFileExpInMinutesTemp))
                {
                    tempFileExpInMinutes = tempFileExpInMinutesTemp;
                }
                return tempFileExpInMinutes;
            }
        }

        public static class TimedService
        {
            public static string CLEAR_EXPERIED_REFRESHTOKEN_CONFIG_NAME = "ClearExpRefeshToken";
            public static string CLEAR_TEMP_FILE_CONFIG_NAME = "ClearTempFile";
        }
    }
}
