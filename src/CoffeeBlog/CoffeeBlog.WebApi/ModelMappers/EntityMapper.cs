using CoffeeBlog.WebApi.Services;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CoffeeBlog.WebApi.ModelMappers
{
    public class EntityMapper : IEntityMapper
    {
        public IEnumerable<IEntityMap> Mappings { get; protected set; }

        public void MapEntities(ModelBuilder modelBuilder)
        {
            foreach (var item in Mappings)
            {
                item.Map(modelBuilder);
            }
        }
    }
}
