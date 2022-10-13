namespace MartiFood_API.Data.Entities

{
    public class Product
    {
        public Guid Id { set; get; }
        public decimal? Price { set; get; }
        public int? ViewCount { set; get; }
        public DateTime? DateCreated { set; get; }

        public virtual ICollection<ProductInCategory> ProductInCategories { get; set; } = null!;

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = null!;

        public virtual ICollection<CartDetail> CartDetails { get; set; } = null!;

        public virtual ICollection<ProductTranslation> ProductTranslations { get; set; } = null!;

        public virtual ICollection<ProductImage> ProductImages { get; set; } = null!;

    }
}
