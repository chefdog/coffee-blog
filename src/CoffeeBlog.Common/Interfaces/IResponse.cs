namespace CoffeeBlog.Common.Interfaces
{
    public interface IResponse
    {
        string Version { get; set; }
        string Message { get; set; }
        bool DidError { get; set; }
        string ErrorMessage { get; set; }
    }
}
