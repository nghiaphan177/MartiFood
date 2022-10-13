namespace MartiFood_API.Data.Entities
{
    public class ProductTranslation
    {
        public Guid Id { set; get; }
        public Guid ProductId { set; get; }
        public string Name { set; get; } = null!;
        public string Description { set; get; } = null!;
        public string Details { set; get; } = null!;
        public string SeoDescription { set; get; } = null!;
        public string SeoTitle { set; get; } = null!;

        public string SeoAlias { get; set; } = null!;
        public string? LanguageId { set; get; }

        public virtual Product Product { get; set; } = null!;

        public virtual Language Language { get; set; } = null!;
    }
}
