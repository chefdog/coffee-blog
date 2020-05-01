using System.Collections.Generic;

namespace CoffeeBlog.WebApi.Interfaces
{
    public interface IListResultResponse<TModel> : IResponse
    {
        int PageSize { get; set; }
        int PageNumber { get; set; }
        IEnumerable<TModel> Model { get; set; }
    }
}
