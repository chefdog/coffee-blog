using CoffeeBlog.WebApi.Interfaces;
using CoffeeBlog.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeBlog.WebApi.ModelMappers
{
    public class TagModelMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Tag>();
            entity.ToTable("Tag", "ct");
            entity.HasKey(t => new { t.Id });
            entity.Property(t => t.Id).UseIdentityColumn();
        }
    }
}