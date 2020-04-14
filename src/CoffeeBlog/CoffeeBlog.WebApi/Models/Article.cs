using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.WebApi.Models
{
    public class Article : BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
