namespace CoffeeBlog.WebApi.DataTransferModels
{
    public class ParagraphDataTransferModel : BaseDto
    {
        public string Paragraph { get; set; }
        public long ArticleId { get; set; }
    }
}
