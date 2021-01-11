using CoffeeBlog.Common.Interfaces;
using System.Collections.Generic;

namespace CoffeeBlog.WebApi.Responses
{
    public class ListResultResponse<TModel> : IListResultResponse<TModel>
    {
        public string Version { get; set; }
        public string Message { get; set; }

        public bool DidError { get; set; }

        public string ErrorMessage { get; set; }

        public int PageSize { get; set; }

        public int PageNumber { get; set; }

        public IList<TModel> Model { get; set; }
    }
}
