﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBlog.WebApi.Models
{
    public class Image : BaseModel
    {
        public long ReferenceId { get; set; }

        public string fileName { get; set; }
    }
}
