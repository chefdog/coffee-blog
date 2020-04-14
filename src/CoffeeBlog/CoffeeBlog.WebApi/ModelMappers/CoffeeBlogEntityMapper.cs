using CoffeeBlog.WebApi.Services;
using System.Collections.Generic;

namespace CoffeeBlog.WebApi.ModelMappers
{
    public class CoffeeBlogEntityMapper : EntityMapper
    {
        public CoffeeBlogEntityMapper()
        {
            Mappings = new List<IEntityMap>()
            {
                new ArticleModelMap() as IEntityMap,
                
            };
        }
    }
}
