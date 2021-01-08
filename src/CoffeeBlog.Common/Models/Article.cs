using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.Common.Models
{
    public class Article : BaseModel
    {
        public ArticleMetaData MetaData { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public List<Paragraph> Paragraphs { get; set; }
    }
}
