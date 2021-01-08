using CoffeeBlog.Common.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace CoffeeBlog.Common.Models
{
    public abstract class BaseModel : IModel
    {
        [Required]
        public long Id { get; set; }
        public long UserId { get; set; }
        public Guid RowGuid { get; set; }
    }
}
