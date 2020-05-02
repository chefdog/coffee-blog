using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.WebApi.DataTransferModels
{
    public class ImageDataTransferModel : BaseDto
    {

        public string FileName { get; internal set; }
    }
}
