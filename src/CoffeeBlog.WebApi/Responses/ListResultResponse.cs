using CoffeeBlog.WebApi.Interfaces;
using System.Collections.Generic;

namespace CoffeeBlog.WebApi.Responses
{
    public class ListResultResponse<TModel> : IListResultResponse<TModel>
    {
        public string Message { get; set; }

        public bool DidError { get; set; }

        public string ErrorMessage { get; set; }

        public int PageSize { get; set; }

        public int PageNumber { get; set; }

        public IEnumerable<TModel> Model { get; set; }
    }
}
