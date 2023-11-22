using BaseNetCoreApi.Infrastructure.Models.QUAN_LY_THU_PHIEntities;
using BaseNetCoreApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace BaseNetCoreApi.Infrastructure.ContextProvider
{
    public interface IContextProvider<TContext> where TContext : DbContext
    {
        ReadOnlyCollection<SQLConnectEntity> getListDB();
        TContext GetContext(int ma_nam_hoc, bool isWriteEntity = false, string ma_cap_hoc = "");
    }
}
