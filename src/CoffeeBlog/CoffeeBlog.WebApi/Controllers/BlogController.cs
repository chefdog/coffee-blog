using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeBlog.WebApi.DataTransferModels;
using CoffeeBlog.WebApi.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoffeeBlog.WebApi.Controllers
{
    [Route("api/[controller]")]
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
        public async Task<IEnumerable<ArticleDataTransferModel>> GetAsync()
        {
            var articles = await blogService.GetMany(0, 0, 100);
            var result = articles.AsEnumerable();
            return result;
        }
    }
}