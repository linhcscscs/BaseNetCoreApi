using BaseNetCoreApi.Models.Entities;
using System.Collections.ObjectModel;

namespace BaseNetCoreApi.Values
{
    public class SQLConnectionEntitiesValues
    {
        public static readonly ReadOnlyCollection<SQLConnectEntity> CSDLBO = new ReadOnlyCollection<SQLConnectEntity>(new[]{
                new SQLConnectEntity(2021, "ConnectionCSDLBO_2021_R1", "ConnectionCSDLBO_2021_R2" , "ConnectionCSDLBO_2021"),
                new SQLConnectEntity(2022, "ConnectionCSDLBO_2022_R1", "ConnectionCSDLBO_2022_R2" , "ConnectionCSDLBO_2022"),
                new SQLConnectEntity(2023, "ConnectionCSDLBO_2023_R1", "ConnectionCSDLBO_2023_R2" , "ConnectionCSDLBO_2023"),
        });

        public static readonly ReadOnlyCollection<SQLConnectEntity> QLTHUPHI =
            new ReadOnlyCollection<SQLConnectEntity>(new[]
            {
                new SQLConnectEntity(2017, "ConnectionQLTHUPHI_2017_R1", "ConnectionQLTHUPHI_2017_R2" , "ConnectionQLTHUPHI_2017"),
                new SQLConnectEntity(2018, "ConnectionQLTHUPHI_2018_R1", "ConnectionQLTHUPHI_2018_R2" , "ConnectionQLTHUPHI_2018"),
                new SQLConnectEntity(2019, "ConnectionQLTHUPHI_2019_R1", "ConnectionQLTHUPHI_2019_R2" , "ConnectionQLTHUPHI_2019"),
                new SQLConnectEntity(2020, "ConnectionQLTHUPHI_2020_R1", "ConnectionQLTHUPHI_2020_R2" , "ConnectionQLTHUPHI_2020"),
                new SQLConnectEntity(2021, "ConnectionQLTHUPHI_2021_R1", "ConnectionQLTHUPHI_2021_R2" , "ConnectionQLTHUPHI_2021"),
                new SQLConnectEntity(2022, "ConnectionQLTHUPHI_2022_R1", "ConnectionQLTHUPHI_2022_R2" , "ConnectionQLTHUPHI_2022"),
                new SQLConnectEntity(2023, "ConnectionQLTHUPHI_2023_R1", "ConnectionQLTHUPHI_2023_R2" , "ConnectionQLTHUPHI_2023"),
            });
    }
}
