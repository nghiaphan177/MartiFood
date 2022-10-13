using MartiFood_API.Data.Enums;

namespace MartiFood_API.Data.Entities

{
    public class Order
    {
        public Guid Id { set; get; }
        public DateTime OrderDate { set; get; }
        public Guid UserId { set; get; }
        public string? ShipName { set; get; }
        public string? ShipAddress { set; get; }
        public string? ShipEmail { set; get; }
        public string? ShipPhoneNumber { set; get; }
        public OrderStatus OrderStatus { set; get; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = null!;

        public virtual AppUser AppUser { get; set; } = null!;
        public Guid PromotionId { get; set; }
        public virtual Promotion Promotion { set; get; } = null!;
    }
}
