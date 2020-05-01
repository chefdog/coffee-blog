﻿namespace CoffeeBlog.WebApi.Interfaces
{
    public interface ISingleResultResponse<TModel> : IResponse
    {
        TModel Model { get; set; }
    }
}
