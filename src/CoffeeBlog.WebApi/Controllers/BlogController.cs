using System.Threading.Tasks;
using CoffeeBlog.Common.Enums;
using CoffeeBlog.Common.Interfaces;
using CoffeeBlog.WebApi.DataTransferModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoffeeBlog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]
    public class BlogController : BaseController
    {
        private IBusinessService<ArticleDataTransferModel> blogService;

        public BlogController(ILogger<BlogController> logger, IBusinessService<ArticleDataTransferModel> blogService)
        {
            this.blogService = blogService;
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync(int max = 10, int pageNumber = 1)
        {
            return ToApiListResponse<ArticleDataTransferModel>(data: await blogService.GetMany(pageNumber, 0, max));
        }

        [HttpGet("{articleType}")]
        public async Task<IActionResult> GetByArticleTypeAsync(string articleType)
        {
            return ToApiListResponse<ArticleDataTransferModel>(data: await blogService.Search(
                    new ArticleDataTransferModel { ArticleType = (ArticleType)System.Enum.Parse(typeof(ArticleType), articleType) },
                    1,
                    0,
                    100
                ));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return ToApiResponse<ArticleDataTransferModel>(await blogService.GetById(id));
        }
    }
}