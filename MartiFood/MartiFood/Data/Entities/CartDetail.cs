namespace MartiFood_API.Data.Entities
{
    public class CartDetail
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;
        public decimal Cost { get; set; }
        public DateTime? DateCreated { get; set; }
        public int Quantity { get; set; }
        public Guid CartId { get; set; }
        public virtual Cart Cart { get; set; } = null!;
    }
}
