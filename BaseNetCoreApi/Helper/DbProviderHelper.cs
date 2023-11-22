using BaseNetCoreApi.Infrastructure.Models.QUAN_LY_THU_PHIEntities;
using BaseNetCoreApi.Models.Entities;
using BaseNetCoreApi.Values;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace BaseNetCoreApi.Helper
{
    public static class DbProviderHelper
    {
        public static string GetReadWriteConnectionString(int ma_nam_hoc, ReadOnlyCollection<SQLConnectEntity> sqlConnects, bool isWriteEntity = false, string ma_cap_hoc = "")
        {
            var configDatabase = sqlConnects.FirstOrDefault(c => c.MA_NAM_HOC == ma_nam_hoc);
            if (configDatabase == null) configDatabase = sqlConnects.FirstOrDefault();

            if (configDatabase == null) return "";

            if (isWriteEntity)
                return configDatabase.SQL_CONNECTION_STRING_WRITE;
            else
            {
                if (ma_cap_hoc == SysCapHoc.C1 || ma_cap_hoc == SysCapHoc.C2)
                {
                    if (!string.IsNullOrEmpty(configDatabase.SQL_CONNECTION_STRING_READ_02))
                        return configDatabase.SQL_CONNECTION_STRING_READ_02;
                }
                return configDatabase.SQL_CONNECTION_STRING_READ_01;
            }
        }
        public static T SetDetectChangesEnabled<T>(this T context) where T : DbContext
        {
            context.ChangeTracker.AutoDetectChangesEnabled = true;
            return context;
        }

        public static T GetContext<T>(int ma_nam_hoc, ReadOnlyCollection<SQLConnectEntity> sqlConnects, bool isWriteEntity = false, string ma_cap_hoc = "") where T : DbContext, new()
        {
            var context = new T();

            // AutoDetectChangesEnabled = false
            context.ChangeTracker.AutoDetectChangesEnabled = false;
            // ProxyCreationEnabled = false
            context.ChangeTracker.LazyLoadingEnabled = false;

            context.Database.SetConnectionString(GetReadWriteConnectionString(ma_nam_hoc, sqlConnects, isWriteEntity, ma_cap_hoc));
            return context;
        }
    }
}
