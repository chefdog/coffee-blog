﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.WebApi.DataTransferModels
{
    public class ArticleDataTransferModel : BaseDto
    {
        
        public List<ParagraphDataTransferModel> Paragraphs { get; set; }
    }
}
