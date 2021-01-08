using CoffeeBlog.WebApi.Interfaces;
using System;

namespace CoffeeBlog.WebApi.DataTransferModels
{
    public abstract class BaseDto : IModel
    {
        public Int64 Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string LastModifiedBy { get; set; }
       
    }
}
