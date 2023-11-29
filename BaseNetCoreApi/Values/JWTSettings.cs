using BaseNetCoreApi.Helper;

namespace BaseNetCoreApi.Values
{
    public static class JWTSettings
    {
        public static string Secret
        {
            get
            {
                return ConfigurationHelper.GetConfigByName("JWT:Secret");
            }
        }
        public static double TokenValidityInMinutes
        {
            get
            {
                return double.Parse(ConfigurationHelper.GetConfigByName("JWT:TokenValidityInMinutes"));
            }
        }

        public static double RefreshTokenValidityInDays
        {
            get
            {
                return double.Parse(ConfigurationHelper.GetConfigByName("JWT:RefreshTokenValidityInDays"));
            }
        }

        public static string ValidAudience
        {
            get
            {
                return ConfigurationHelper.GetConfigByName("JWT:ValidAudience");
            }
        }

        public static string ValidIssuer
        {
            get
            {
                return ConfigurationHelper.GetConfigByName("JWT:ValidIssuer");
            }
        }
    }
}
