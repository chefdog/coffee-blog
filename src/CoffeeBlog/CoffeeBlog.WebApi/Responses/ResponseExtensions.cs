using CoffeeBlog.WebApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace CoffeeBlog.WebApi.Responses
{
    public static class ResponseExtensions
    {
        public static IActionResult ToHttpResponse<TModel>(this IListResultResponse<TModel> response)
        {
            var status = HttpStatusCode.OK;

            if (response.DidError)
            {
                status = HttpStatusCode.InternalServerError;
            }
            else if (response.Model == null)
            {
                status = HttpStatusCode.NoContent;
            }

            return new ObjectResult(response)
            {
                StatusCode = (Int32)status
            };
        }

        public static IActionResult ToHttpResponse<TModel>(this ISingleResultResponse<TModel> response)
        {
            var status = HttpStatusCode.OK;

            if (response.DidError)
            {
                status = HttpStatusCode.InternalServerError;
            }
            else if (response.Model == null)
            {
                status = HttpStatusCode.NotFound;
            }

            return new ObjectResult(response)
            {
                StatusCode = (Int32)status
            };
        }
    }
}
