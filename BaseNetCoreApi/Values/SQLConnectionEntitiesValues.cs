using BaseNetCoreApi.Models.Entities;
using System.Collections.ObjectModel;

namespace BaseNetCoreApi.Values
{
    public class SQLConnectionEntitiesValues
    {
        public static readonly ReadOnlyCollection<SQLConnectEntity> PHO_CAP_GD =
            new ReadOnlyCollection<SQLConnectEntity>(new[]
            {
                new SQLConnectEntity(2022, "ConnectionPHOCAPGD_2022_R1", "ConnectionPHOCAPGD_2022_R2" , "ConnectionPHOCAPGD_2022"),
            });
    }
}
