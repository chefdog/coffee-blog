using CoffeeBlog.WebApi.Interfaces;
using System;

namespace CoffeeBlog.WebApi.Models
{
    public abstract class BaseModel : IModel
    {
        public long Id { get; set; }
        public long UserId { get; set; }
    }
}
