using System;

namespace CoffeeBlog.WebApi.Interfaces
{
    public interface IModel
    {
        DateTime Created { get; set; }
        DateTime LastModified { get; set; }
        string LastModifiedBy { get; set; }
        
    }
}
