using BaseNetCoreApi.Helper;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.Dtos
{
    public class PaginationRequest<T> where T : class, new()
    {
        public int? PageIndex { get; set; } = 1;
        public int? PageSize { get; set; } = 10;
        public T Filter { get; set; } = new T();
    }
    public class PaginationModel<T>
    {
        public int? PageIndex { get; set; } = 1;
        public int? PageSize { get; set; } = 10;
        public IQueryable<T> Queryable { get; set; }
    }
    public class PaginationResponse<T>
    {

        public PaginationResponse()
        {
        }
        public PaginationResponse(PaginationModel<T> model)
        {
            PageIndex = model.PageIndex > 0 ? model.PageIndex.Value : 1;
            TotalItems = model.Queryable.Count();
            if (model.PageSize == null || model.PageSize > ConfigurationHelper.MaxPageSize)
            {
                PageSize = ConfigurationHelper.MaxPageSize;
            }
            else
            {
                PageSize = model.PageSize.Value;
            }
            TotalPages = (long)Math.Ceiling((double)TotalItems / PageSize);
            Data = model.Queryable.Skip(PageIndex - 1).Take(PageSize).ToList();
        }

        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public long TotalItems { get; set; }
        public long TotalPages { get; set; }
        public List<T> Data { get; set; }
    }


}
