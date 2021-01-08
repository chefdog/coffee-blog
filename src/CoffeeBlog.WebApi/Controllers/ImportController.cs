using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeBlog.WebApi.DataTransferModels;
using CoffeeBlog.WebApi.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeBlog.WebApi.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class ImportController : ControllerBase
    {
        private IBusinessService<ImageDataTransferModel> imageService;
        private IBusinessService<ArticleDataTransferModel> blogService;
        public ImportController(IBusinessService<ImageDataTransferModel> imageService, IBusinessService<ArticleDataTransferModel> blogService)
        {
            this.imageService = imageService;
            this.blogService = blogService;
        }

        
    }
}
