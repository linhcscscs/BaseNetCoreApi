using BaseNetCoreApi.Infrastructure.Models.PHO_CAP_GDEntities;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;

namespace BaseNetCoreApi.Infrastructure.Repository.Interface
{
    public interface IUnitOfWork
    {
        void SetNamHoc(int maNamHoc);
        int NamHoc { get; }
        PHO_CAP_GDEntities ReadContext { get; }
        PHO_CAP_GDEntities WriteContext { get; }
        void SaveChange();
        void BulkSaveChanges(BulkConfig bulkConfig);
    }
}
