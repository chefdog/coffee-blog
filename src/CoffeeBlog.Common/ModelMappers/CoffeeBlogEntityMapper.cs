using CoffeeBlog.Common.Interfaces;
using System.Collections.Generic;

namespace CoffeeBlog.Common.ModelMappers
{
    public class CoffeeBlogEntityMapper : EntityMapper
    {
        public CoffeeBlogEntityMapper()
        {
            Mappings = new List<IEntityMap>()
            {
                new ArticleModelMap() as IEntityMap
            };
        }
    }
}
