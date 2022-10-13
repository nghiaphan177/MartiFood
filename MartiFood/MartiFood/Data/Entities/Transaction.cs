using MartiFood_API.Data.Enums;

namespace MartiFood_API.Data.Entities

{
    public class Transaction
    {
        public Guid Id { set; get; }
        public DateTime TransactionDate { set; get; }
        public string ExternalTransactionId { set; get; } = null!;
        public decimal Amount { set; get; }
        public decimal Fee { set; get; }
        public string Result { set; get; } = null!;
        public string Message { set; get; } = null!;
        public TransactionStatus Status { set; get; }
        public string Provider { set; get; } = null!;

        public Guid UserId { get; set; }

        public virtual AppUser AppUser { get; set; } = null!;
    }
}
