using MartiFood_API.Data.Enums;

namespace MartiFood_API.Data.Entities
{
    public class Contact
    {
        public Guid Id { set; get; }
        public string Name { set; get; } = null!;
        public string Email { set; get; } = null!;
        public string PhoneNumber { set; get; } = null!;
        public string Message { set; get; } = null!;
        public Status Status { set; get; }
    }
}
