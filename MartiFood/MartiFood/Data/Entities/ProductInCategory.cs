namespace MartiFood_API.Data.Entities
{
    public class ProductInCategory
    {
        public Guid ProductId { get; set; }

        public virtual Product Product { get; set; } = null!;

        public Guid CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;
    }
}
