using MartiFood_API.Data.Enums;

namespace MartiFood_API.Data.Entities
{
    public class Promotion
    {
        public Guid Id { get; set; }
        public DateTime FromDate { set; get; }
        public DateTime ToDate { set; get; }
        public int? DiscountPercent { set; get; }
        public decimal? DiscountAmount { set; get; }
        public decimal? MinimumOrderValue { set; get; }
        public Status Status { set; get; }
        public string? Name { set; get; }
    }
}
