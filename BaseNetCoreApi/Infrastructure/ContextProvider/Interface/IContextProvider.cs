using BaseNetCoreApi.Infrastructure.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace BaseNetCoreApi.Infrastructure.ContextProvider.Interface
{
    public interface IContextProvider<TContext> where TContext : DbContext, new()
    {
        ReadOnlyCollection<SQLConnectEntity> getListDB { get; }
        TContext GetContext(int ma_nam_hoc, bool isWriteEntity = false, string ma_cap_hoc = "");
        public TContext GetRead(int ma_nam_hoc, string ma_cap_hoc = "");
        public TContext GetWrite(int ma_nam_hoc, string ma_cap_hoc = "");
    }
}
