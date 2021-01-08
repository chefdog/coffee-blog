using Microsoft.EntityFrameworkCore;

namespace CoffeeBlog.Common.Interfaces
{
    public interface IEntityMap
    {
        void Map(ModelBuilder modelBuilder);
    }
}
