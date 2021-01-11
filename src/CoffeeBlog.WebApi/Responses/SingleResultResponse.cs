

using CoffeeBlog.Common.Interfaces;

namespace CoffeeBlog.WebApi.Responses
{
    public class SingleResultResponse<TModel> : ISingleResultResponse<TModel>
    {
        public string Version { get; set; }
        public string Message { get; set; }

        public bool DidError { get; set; }

        public string ErrorMessage { get; set; }

        public TModel Model { get; set; }
    }
}
