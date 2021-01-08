using CoffeeBlog.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.WebApi.ModelMappers
{
    public static class TagDataTransferModelMapper
    {
        public static string ToStringValue(this List<Tag> entities)
        {
            var data = string.Concat(entities.Select(t => t.Title));
            return data;
        }
    }
}
