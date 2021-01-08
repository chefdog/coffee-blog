using CoffeeBlog.WebApi.Interfaces;
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
                new TagModelMap() as IEntityMap,
                new ImageModelMap() as IEntityMap
            };
        }
    }
}
