using CoffeeBlog.WebApi.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace CoffeeBlog.WebApi.Models
{
    public abstract class BaseModel : IModel
    {
        [Required]
        public long Id { get; set; }
        public long UserId { get; set; }
        public Guid RowGuid { get; set; }
    }
}
