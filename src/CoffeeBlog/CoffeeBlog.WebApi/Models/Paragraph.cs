using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.WebApi.Models
{
    public class Paragraph : BaseModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
