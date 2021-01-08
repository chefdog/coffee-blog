using CoffeeBlog.WebApi.DataTransferModels;
using CoffeeBlog.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.WebApi.ModelMappers
{
    public static class ArticleDataTransferModelMapper
    {
        public static ArticleDataTransferModel ToDto(this Article entity) {
            return new ArticleDataTransferModel
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description,
                Created = entity.MetaData.PublishDate,
                LastModified = entity.MetaData.LastModified,
                Paragraphs = entity.Paragraphs.Select(p => p.ToDto()).ToList()
            };
        }

        public static Article ToModel(this ArticleDataTransferModel entity)
        {
            return new Article
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description,
                Paragraphs = entity.Paragraphs.Select(p => p.ToDto()).ToList(),
                MetaData = new ArticleMetaData {
                    ArticleId = entity.Id,
                    PublishDate = entity.LastModified,
                    Id = entity.Id,
                    ArticleType = entity.ArticleType,
                    Tags = entity.Tags
                }
            };
        }
    }
}
