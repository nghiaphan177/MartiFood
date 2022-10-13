namespace MartiFood_API.Data.Entities
{
    public class CategoryTranslation
    {
        public Guid Id { set; get; }
        public Guid CategoryId { set; get; }
        public string? Name { set; get; }
        public string? SeoDescription { set; get; }
        public string? SeoTitle { set; get; }
        public string? LanguageId { set; get; }
        public string? SeoAlias { set; get; }

        public virtual Category Category { get; set; } = null!;

        public virtual Language Language { get; set; } = null!;
    }
}
