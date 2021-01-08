namespace CoffeeBlog.Common.Interfaces
{
    public interface ISingleResultResponse<TModel> : IResponse
    {
        TModel Model { get; set; }
    }
}
