using CoffeeBlog.Common.Enums;
using CoffeeBlog.Common.Interfaces;
using CoffeeBlog.Common.Models;
using CoffeeBlog.WebApi.Common;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.WebApi.Services.BlogService
{
    public class ArticleJsonRepository : IRepository<Article>
    {
        private readonly string publishedFolder;
        public ArticleJsonRepository(IOptions<AppSettings> options)
        {
            publishedFolder = options.Value.PublishedFolder;
        }

        
        public async Task<IModel> AddAsync(IModel entity)
        {
            var article = new Article();
                article.MetaData = new ArticleMetaData {
                PublishDate = DateTime.Now,
                ArticleId = 1,
                ArticleType = ArticleType.review,
                ArticleSubType = ArticleType.coffee,
                Author = "M.A. van Zuijlen",
                Id = 1,
                Tags = new List<string> { "coffee", "bocca" }
            };
            
            article.Description = "In mijn koffie lab is het vooral koffie van Bocca wat ik zelf drink. "+
                "Maar er zijn in Nederland zoveel zulke goede roasters, dus nu een koffie van Giraffe Koffie in de maler."+
                " Ik had een proefpakket espresso single origins aangeschaft. "
                +"Hierin zitten dan 3 verschillende bonen en ik ben begonnen deze week met Monte Alto.";

            article.Id = 2;            
            article.Title = "Monte Alto, Giraffe koffie";
            article.UserId = 1;
            article.Paragraphs = new List<Paragraph>();
            article.Paragraphs.Add(new Paragraph { 
                Content = "Ik ken Giraffe al wat langer, een aantal jaar geleden had ik al koffie van Giraffe online aangeschaft. "
                +"Tot mijn grote verbazing werd de koffie afgeleverd door een van de eigenaren. "
                +"Hij kwam met veel enthausiasme uitleggen dat ze niet zomaar hun bonen wilden verkopen, zonder dat iemand daar dezelfde pasie voor had en zijn mooie product op een verkeerde manier gingen gebruiken. Dus zei, kom binnen en kan je zien wat ik heb staan. Hij was gerust gesteld."
            });

            var result = JsonConvert.SerializeObject(article);
            var di = new DirectoryInfo(this.publishedFolder);
            await File.WriteAllTextAsync(di.FullName + $@"\Monte-Alto-{article.MetaData.PublishDate.Ticks}.json", result);

            return (IModel)article;
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
            Article article = null;

            foreach (var f in files)
            {
                using (StreamReader file = File.OpenText(f.FullName))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    article = (Article)serializer.Deserialize(file, typeof(Article));
                }
                result.Add(article);
            }
           
            return result.Cast<IModel>().AsQueryable();
        }

        public Task<IModel> UpdateAsync(IModel changes)
        {
            throw new NotImplementedException();
        }
    }
}
