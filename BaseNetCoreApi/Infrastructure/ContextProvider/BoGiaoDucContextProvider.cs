using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.Models.BO_GIAO_DUCEntities;
using BaseNetCoreApi.Infrastructure.Models.QUAN_LY_THU_PHIEntities;
using BaseNetCoreApi.Models.Entities;
using BaseNetCoreApi.Values;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Configuration;

namespace BaseNetCoreApi.Infrastructure.ContextProvider
{
    public interface IBoGiaoDucContextProvider : IContextProvider<BO_GIAO_DUCEntities>
    {

    }
    public class BoGiaoDucContextProvider : IBoGiaoDucContextProvider
    {
        public ReadOnlyCollection<SQLConnectEntity> getListDB()
        {
            return SQLConnectionEntitiesValues.CSDLBO;
        }

        public BO_GIAO_DUCEntities GetContext(int ma_nam_hoc, bool isWriteEntity = false, string ma_cap_hoc = "")
        {
            return DbProviderHelper.GetContext<BO_GIAO_DUCEntities>(ma_nam_hoc, SQLConnectionEntitiesValues.CSDLBO, isWriteEntity, ma_cap_hoc);
        }
    }
}
