namespace MartiFood_API.Data.Entities

{
    public class OrderDetail
    {
        public Guid Id { set; get; }
        public Guid ProductId { set; get; }
        public Guid OrderId { get; set; }
        public int Quantity { set; get; }
        public decimal Cost { set; get; }

        public virtual Order Order { get; set; } = null!;

        public virtual Product Product { get; set; } = null!;
    }
}
