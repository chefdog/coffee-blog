using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.WebApi.DataTransferModels
{
    public abstract class BaseDto
    {
        public Int64 Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string LastModifiedBy { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
    }
}
