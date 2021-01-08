using CoffeeBlog.WebApi.Interfaces;
using CoffeeBlog.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.WebApi.ModelMappers
{
    public class ImageModelMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Image>();
            entity.ToTable("Image", "ct");
            entity.HasKey(i => new { i.Id });
            entity.Property(p => p.Id).UseIdentityColumn();
        }
    }
}
