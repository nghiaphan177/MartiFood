namespace MartiFood_API.Data.Entities
{
    public class ProductImage
    {
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        public string ImagePath { get; set; } = null!;

        public string Caption { get; set; } = null!;

        public bool IsDefault { get; set; }

        public DateTime? DateCreated { get; set; }

        public long FileSize { get; set; }

        public virtual Product Product { get; set; } = null!;
    }
}

