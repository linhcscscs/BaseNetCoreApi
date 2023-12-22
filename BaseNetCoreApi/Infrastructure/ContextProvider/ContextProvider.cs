using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.ContextProvider.Interface;
using BaseNetCoreApi.Infrastructure.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.Entities;
using BaseNetCoreApi.Values;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace BaseNetCoreApi.Infrastructure.ContextProvider
{
    public abstract class ContextProvider<TContext> : IContextProvider<TContext> where TContext : DbContext, new()
    {
        private Dictionary<(int, string), TContext> _listReadContext
           = new Dictionary<(int, string), TContext>();
        private Dictionary<(int, string), TContext> _listWriteContext
            = new Dictionary<(int, string), TContext>();
        public abstract ReadOnlyCollection<SQLConnectEntity> getListDB { get; }

        public TContext GetContext(int ma_nam_hoc, bool isWriteEntity = false, string ma_cap_hoc = "")
        {
            return DbProviderHelper.GetContext<TContext>(ma_nam_hoc, getListDB, isWriteEntity, ma_cap_hoc);
        }
        public TContext GetRead(int ma_nam_hoc, string ma_cap_hoc = "")
        {
            TContext readContext;
            if (!_listReadContext.TryGetValue((ma_nam_hoc, ma_cap_hoc), out readContext!))
            {
                readContext = GetContext(ma_nam_hoc, false, ma_cap_hoc);
                _listReadContext.Add((ma_nam_hoc, ma_cap_hoc), readContext);
            }
            return readContext;
        }
        public TContext GetWrite(int ma_nam_hoc, string ma_cap_hoc = "")
        {
            TContext writeContext;
            if (!_listWriteContext.TryGetValue((ma_nam_hoc, ma_cap_hoc), out writeContext!))
            {
                writeContext = GetContext(ma_nam_hoc, true, ma_cap_hoc);
                _listWriteContext.Add((ma_nam_hoc, ma_cap_hoc), writeContext);
            }
            return writeContext;
        }
    }
}
