using Microsoft.EntityFrameworkCore;

namespace CoffeeBlog.WebApi.Interfaces
{
    public interface IEntityMap
    {
        void Map(ModelBuilder modelBuilder);
    }
}
