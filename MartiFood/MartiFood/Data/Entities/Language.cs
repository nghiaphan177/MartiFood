namespace MartiFood_API.Data.Entities
{
    public class Language
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public bool IsDefault { get; set; }

        public virtual ICollection<ProductTranslation> ProductTranslations { get; set; } = null!;

        public virtual ICollection<CategoryTranslation> CategoryTranslations { get; set; } = null!;

    }
}
