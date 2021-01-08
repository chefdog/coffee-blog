using CoffeeBlog.WebApi.Common;
using System.Collections.Generic;

namespace CoffeeBlog.WebApi.DataTransferModels
{
    public class ArticleDataTransferModel : BaseDto
    {
        public List<ParagraphDataTransferModel> Paragraphs { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ArticleType ArticleType { get; set; }
        public List<string> Tags { get; set; }
    }
}
