using CoffeeBlog.WebApi.Common;
using CoffeeBlog.WebApi.DataTransferModels;
using CoffeeBlog.WebApi.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.WebApi.Services.BlogService
{
    public class BlogBusinessService : IBusinessService<BlogDataTransferModel>
    {
        private AppSettings appSettings;
        public BlogBusinessService(IOptions<AppSettings> options, IRepository articleJsonRepos) {
            appSettings = options.Value;
        }

        public Task<BlogDataTransferModel> Create(BlogDataTransferModel dto)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<BlogDataTransferModel> Find(BlogDataTransferModel dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<BlogDataTransferModel>> GetMany(int start, int skip, int max)
        {
            throw new NotImplementedException();
        }

        public Task<BlogDataTransferModel> Remove(BlogDataTransferModel dto)
        {
            throw new NotImplementedException();
        }

        public Task<BlogDataTransferModel> Update(BlogDataTransferModel dto)
        {
            throw new NotImplementedException();
        }
    }
}
