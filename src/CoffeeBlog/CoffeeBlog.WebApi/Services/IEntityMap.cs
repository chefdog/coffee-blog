using Microsoft.EntityFrameworkCore;

namespace CoffeeBlog.WebApi.Services
{
    public interface IEntityMap
    {
        void Map(ModelBuilder modelBuilder);
    }
}
