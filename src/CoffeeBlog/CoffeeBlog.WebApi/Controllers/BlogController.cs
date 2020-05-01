using System;
using System.Linq;
using System.Threading.Tasks;
using CoffeeBlog.WebApi.Common;
using CoffeeBlog.WebApi.DataTransferModels;
using CoffeeBlog.WebApi.Interfaces;
using CoffeeBlog.WebApi.Responses;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoffeeBlog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private IBusinessService<ArticleDataTransferModel> blogService;
        private readonly ILogger<BlogController> logger;
        public BlogController(ILogger<BlogController> logger, IBusinessService<ArticleDataTransferModel> blogService)
        {
            this.blogService = blogService;
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync(int? max = 10, int? pageNumber = 1)
        {
            var response = new ListResultResponse<ArticleDataTransferModel>();
            try
            {
                response.PageSize = (int)max;
                response.PageNumber = (int)pageNumber;
                response.Model = await blogService.GetMany(0, 0, 100);
                response.Message = $"Total of records: {response.Model.Count()}";
            }
            catch (Exception ex)
            {
                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return response.ToHttpResponse();
        }

        [HttpGet("{articleType}")]
        public async Task<IActionResult> GetByArticleTypeAsync(string articleType)
        {
            var response = new ListResultResponse<ArticleDataTransferModel>();
            try
            {
                response.Model = await blogService.Search(
                    new ArticleDataTransferModel { ArticleType = (ArticleType)System.Enum.Parse(typeof(ArticleType), articleType) },
                    1,
                    0,
                    100
                );
                response.Message = $"Total of records: {response.Model.Count()}";
            }
            catch (Exception ex)
            {
                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return response.ToHttpResponse();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var response = new SingleResultResponse<ArticleDataTransferModel>();
            try
            {
                response.Model = await blogService.GetById(id);
                response.Message = $"Fetch record with id: {response.Model.Id}";
            }
            catch (Exception ex)
            {
                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
            return response.ToHttpResponse();
        }
    }
}