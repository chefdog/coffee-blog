using CoffeeBlog.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.WebApi.DataTransferModels
{
    public class BlogDataTransferModel : IModel
    {
        public long Id { get; set; }
    }
}
