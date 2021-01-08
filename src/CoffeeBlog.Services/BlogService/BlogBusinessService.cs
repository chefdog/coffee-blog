using CoffeeBlog.Common.Interfaces;
using CoffeeBlog.Common.Models;
using CoffeeBlog.WebApi.Common;
using CoffeeBlog.WebApi.DataTransferModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.WebApi.Services.BlogService
{
    public class BlogBusinessService : IBusinessService<ArticleDataTransferModel>
    {
        private AppSettings appSettings;
        private ArticleJsonRepository articleRepository;
        public BlogBusinessService(IOptions<AppSettings> options, IRepository<Article> articleRepository)
        {
            appSettings = options.Value;
            this.articleRepository = articleRepository as ArticleJsonRepository;
        }

        public Task<ArticleDataTransferModel> Create(ArticleDataTransferModel dto)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<List<ArticleDataTransferModel>> Search(ArticleDataTransferModel dto, int start, int skip, int max)
        {
            List<ArticleDataTransferModel> result = new List<ArticleDataTransferModel>();
            var data = articleRepository.GetMany(max, start);
            var articles = data.Cast<Article>().Select(a => a.ToDto());
            result = articles.Where(a => a.ArticleType.Equals(dto.ArticleType)).ToList();
            return result;
        }

        public Task<ArticleDataTransferModel> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ArticleDataTransferModel>> GetMany(int start, int skip, int max)
        {
            var articles = articleRepository.GetMany(max, start);
            var result = articles.Cast<Article>().Select(a => a.ToDto());
            return await result.ToListAsync();
        }

        public Task<ArticleDataTransferModel> Remove(ArticleDataTransferModel dto)
        {
            throw new NotImplementedException();
        }

        public Task<ArticleDataTransferModel> Update(ArticleDataTransferModel dto)
        {
            throw new NotImplementedException();
        }
    }
}
