using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.Models.BO_GIAO_DUCEntities;
using BaseNetCoreApi.Infrastructure.Models.QUAN_LY_THU_PHIEntities;
using BaseNetCoreApi.Models.Entities;
using BaseNetCoreApi.Values;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace BaseNetCoreApi.Infrastructure.ContextProvider
{
    public interface IQuanLyThuPhiContextProvider : IContextProvider<QUAN_LY_THU_PHIEntities>
    {

    }
    public class QuanLyThuPhiContextProvider : IQuanLyThuPhiContextProvider
    {
        public ReadOnlyCollection<SQLConnectEntity> getListDB()
        {
            return SQLConnectionEntitiesValues.QLTHUPHI;
        }

        public QUAN_LY_THU_PHIEntities GetContext(int ma_nam_hoc, bool isWriteEntity = false, string ma_cap_hoc = "")
        {
            return DbProviderHelper.GetContext<QUAN_LY_THU_PHIEntities>(ma_nam_hoc, SQLConnectionEntitiesValues.QLTHUPHI, isWriteEntity, ma_cap_hoc);
        }
    }
}
