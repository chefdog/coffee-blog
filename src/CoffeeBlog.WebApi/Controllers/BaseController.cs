using CoffeeBlog.WebApi.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.WebApi.Controllers
{
    public class BaseController : ControllerBase
    {
        protected ILogger logger;

        protected IActionResult ToApiResponse<T>(Func<T> methodName, bool handleFile = false)
        {
            var apiResponse = new SingleResultResponse<T>();
            try
            {
                var result = methodName();
                apiResponse.Model = result;
            }
            catch (Exception ex)
            {
                apiResponse.DidError = true;
                apiResponse.ErrorMessage = string.Empty;
                logger.LogError(ex, ex.Message, apiResponse);
            }
            return Ok(apiResponse);
        }

        protected IActionResult ToApiListResponse<T>(List<T> data, bool handleFile = false)
        {
            var apiResponse = new ListResultResponse<T>();
            try
            {
                apiResponse.Model = data;
                apiResponse.PageNumber = 0;
                apiResponse.PageSize = 100;
            }
            catch (Exception ex)
            {
                apiResponse.DidError = true;
                apiResponse.ErrorMessage = string.Empty;
                logger.LogError(ex, ex.Message, apiResponse);
            }
            return Ok(apiResponse);
        }
    }
}
