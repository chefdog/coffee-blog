﻿using CoffeeBlog.WebApi.DataTransferModels;
using CoffeeBlog.WebApi.Models;

namespace CoffeeBlog.WebApi.ModelMappers
{
    public static class ParagraphDataTransferModelMapper
    {
        public static ParagraphDataTransferModel ToDto(this Paragraph entity) {
            return new ParagraphDataTransferModel { 
                Id = entity.Id,
                Paragraph = entity.Content,
                ArticleId = entity.ArticleId
            };
        }

        public static Paragraph ToDto(this ParagraphDataTransferModel entity)
        {
            return new Paragraph
            {
                Id = entity.Id,
                Content = entity.Paragraph,
                ArticleId = entity.ArticleId
            };
        }
    }
}
