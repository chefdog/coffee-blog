using CoffeeBlog.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.Common.Models
{
    public class ArticleMetaData
    {
        public long Id { get; set; }
        public long ArticleId { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        public ArticleType ArticleType { get; set; }
        public ArticleType ArticleSubType { get; set; }
        public Int16 Rating { get; set; }
        public string ReadMore { get; set; }
        public List<string> Tags { get; set; }
        public DateTime LastModified { get; internal set; }
    }
}
