using CoffeeBlog.Common.Interfaces;
using CoffeeBlog.Common.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeBlog.Common.ModelMappers
{
    public class ArticleModelMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Article>();
            entity.ToTable("Article", "ct");
            entity.HasKey(p => new { p.Id });
            entity.Property(p => p.Id).UseIdentityColumn();
        }
    }
}
