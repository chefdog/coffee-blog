using CoffeeBlog.WebApi.Common;
using CoffeeBlog.WebApi.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CoffeeBlog.WebApi.Services
{
    public class CbDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public CbDbContext(IOptions<AppSettings> appSettings, IEntityMapper entityMapper)
        {
            ConnectionString = appSettings.Value.ConnectionString;

            EntityMapper = entityMapper;
        }

        public string ConnectionString { get; }

        public IEntityMapper EntityMapper { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            EntityMapper.MapEntities(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}
