namespace BaseNetCoreApi.Helper
{
    public static class ConfigurationHelper
    {
        public static IConfiguration Configuration;
        public static string GetConnectionStringByName(string connectionStringName)
        {
            return ConfigurationHelper.Configuration.GetConnectionString(connectionStringName) ?? "";
        }
    }
}
