using CoffeeBlog.WebApi.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.WebApi.DataTransferModels
{
    public class ArticleDataTransferModel : BaseDto
    {
        
        public List<ParagraphDataTransferModel> Paragraphs { get; set; }
        public string Title { get; internal set; }
        public string Description { get; internal set; }
        public ArticleType ArticleType { get; internal set; }
        public List<string> Tags { get; internal set; }
    }
}
