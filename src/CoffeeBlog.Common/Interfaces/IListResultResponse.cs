using System.Collections.Generic;

namespace CoffeeBlog.Common.Interfaces
{
    public interface IListResultResponse<TModel> : IResponse
    {
        int PageSize { get; set; }
        int PageNumber { get; set; }
        IList<TModel> Model { get; set; }
    }
}
