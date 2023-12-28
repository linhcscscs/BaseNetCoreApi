using BaseNetCoreApi.Infrastructure.Models.MongoDb;
using BaseNetCoreApi.Infrastructure.MongoDBClient.Interface;
using BaseNetCoreApi.Models.Dtos;
using BaseNetCoreApi.Models.Model;

namespace BaseNetCoreApi.Models.Collection.Interface
{
    public interface ILogSYSCollection : IMGCollection<LogSYSModel>
    {
        PaginationResponse<LogSYSModel> GetLog(PaginationRequest<GetLogSysFilter> model);
    }
}
