using CoffeeBlog.WebApi.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace CoffeeBlog.WebApi.Controllers
{
    public class BaseController : ControllerBase
    {
        protected ILogger logger;

        protected IActionResult ToApiResponse<T>(T data, bool handleFile = false)
        {
            var apiResponse = new SingleResultResponse<T>();
            try
            {
                apiResponse.Model = data;
                apiResponse.Version = this.GetAssemblyVersion();
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
                apiResponse.Version = this.GetAssemblyVersion();
            }
            catch (Exception ex)
            {
                apiResponse.DidError = true;
                apiResponse.ErrorMessage = string.Empty;
                logger.LogError(ex, ex.Message, apiResponse);
            }
            return Ok(apiResponse);
        }

        protected string GetAssemblyVersion()
        {
            return GetType().Assembly.GetName().Version.ToString();
        }
    }
}
