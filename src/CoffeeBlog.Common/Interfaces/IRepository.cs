using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.Common.Interfaces
{
    public interface IRepository<T> where T:IModel
    {
        IQueryable<IModel> GetMany(Int32 pageSize, Int32 pageNumber);

        Task<IModel> GetAsync(IModel entity);

        Task<IModel> AddAsync(IModel entity);

        Task<List<IModel>> AddRangeAsync(List<IModel> data);

        Task<IModel> UpdateAsync(IModel changes);

        Task<IModel> DeleteAsync(IModel changes);
    }
}
