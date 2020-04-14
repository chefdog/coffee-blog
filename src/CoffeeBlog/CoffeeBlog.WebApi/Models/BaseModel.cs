using System;

namespace CoffeeBlog.WebApi.Models
{
    public abstract class BaseModel
    {
        public long Id { get; set; }

        public DateTime PublisDate { get; set; }

        public long UserId { get; set; }
    }
}
