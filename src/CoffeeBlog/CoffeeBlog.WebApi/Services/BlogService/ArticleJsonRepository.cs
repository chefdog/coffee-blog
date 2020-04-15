using CoffeeBlog.WebApi.Common;
using CoffeeBlog.WebApi.Interfaces;
using CoffeeBlog.WebApi.Models;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.WebApi.Services.BlogService
{
    public class ArticleJsonRepository : IRepository
    {
        private readonly string publishedFolder;
        public ArticleJsonRepository(IOptions<AppSettings> options)
        {
            publishedFolder = options.Value.PublishedFolder;
        }

        
        public Task<IModel> AddAsync(IModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<IModel>> AddRangeAsync(List<IModel> data)
        {
            throw new NotImplementedException();
        }

        public Task<IModel> DeleteAsync(IModel changes)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IModel> GetAsync(IModel entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<IModel> GetMany(int pageSize, int pageNumber)
        {
            var di = new DirectoryInfo(this.publishedFolder);
            var files = di.GetFiles();
            List<Article> result = new List<Article>();
            var articles = files.Select(f => JsonConvert.DeserializeObject<Article>(f.FullName));
            result.AddRange(articles);
            return result.Cast<IModel>().AsQueryable();
        }

        public Task<IModel> UpdateAsync(IModel changes)
        {
            throw new NotImplementedException();
        }
    }
}
