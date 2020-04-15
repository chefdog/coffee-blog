using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.WebApi.DataTransferModels
{
    public class BlogDataTransferModel : BaseDto
    {
        public List<ArticleDataTransferModel> Articles { get; set; }
    }
}
