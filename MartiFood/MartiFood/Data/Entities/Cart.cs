namespace MartiFood_API.Data.Entities
{
    public class Cart
    {
        public Guid Id { get; set; }
        public virtual ICollection<CartDetail> CartDetails { get; set; } = null!;
        public Guid UserId { set; get; }

        public virtual AppUser AppUser { get; set; } = null!;
    }
}
