using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.ContextProvider.Interface;
using BaseNetCoreApi.Infrastructure.Models.PHO_CAP_GDEntities;
using BaseNetCoreApi.Models.Entities;
using BaseNetCoreApi.Values;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace BaseNetCoreApi.Infrastructure.ContextProvider
{
    public class PhoCapGDContextProvider : ContextProvider<PHO_CAP_GDEntities>, IPhoCapGDContextProvider
    {
        public override ReadOnlyCollection<SQLConnectEntity> getListDB
        {
            get => SQLConnectionEntitiesValues.PHO_CAP_GD;
        }
    }
}
