using CoffeeBlog.WebApi.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.WebApi.DataTransferModels
{
    public class ImageDataTransferModel : BaseDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public ImageType ImageType { get; set; }
    }
}
