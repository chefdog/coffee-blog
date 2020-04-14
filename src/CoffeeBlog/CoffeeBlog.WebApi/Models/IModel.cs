using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.WebApi.Models
{
    public interface IModel
    {
        DateTime Created { get; set; }
        DateTime LastModified { get; set; }
        string LastModifiedBy { get; set; }
        string Title { get; set; }
        int Rating { get; set; }
    }
}
