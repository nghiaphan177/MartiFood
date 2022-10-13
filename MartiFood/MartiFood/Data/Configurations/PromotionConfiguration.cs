using MartiFood_API.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MartiFood_API.Data.Configurations
{
    public class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.ToTable("Promotions");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.DiscountAmount).HasPrecision(14, 2);
            builder.Property(x => x.MinimumOrderValue).HasPrecision(14, 2);


            builder.Property(x => x.Name).IsRequired();
        }
    }
}
