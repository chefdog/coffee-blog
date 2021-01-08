using CoffeeBlog.WebApi.DataTransferModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.Common.Interfaces
{
    public interface IService
    {
        Task<List<BlogDataTransferModel>> GetMany(int start, int skip, int max);
    }
}
