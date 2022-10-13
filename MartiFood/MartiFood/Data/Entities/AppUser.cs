using Microsoft.AspNetCore.Identity;

namespace MartiFood_API.Data.Entities

{
    public class AppUser : IdentityUser<Guid>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DOB { get; set; }
        public Guid? CartId { get; set; }
        public virtual Cart Cart { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; } = null!;

        public virtual ICollection<Transaction> Transactions { get; set; } = null!;
    }
}
