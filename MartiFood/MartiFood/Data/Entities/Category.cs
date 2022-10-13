using MartiFood_API.Data.Enums;

namespace MartiFood_API.Data.Entities

{
    public class Category
    {
        public Guid Id { set; get; }

        public Guid? ParentId { set; get; }
        public Status Status { get; set; }

        public virtual ICollection<ProductInCategory> ProductInCategories { get; set; } = null!;

        public virtual ICollection<CategoryTranslation> CategoryTranslations { get; set; } = null!;

    }
}
