using MartiFood_API.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MartiFood_API.Data.Configurations
{
    public class CartDetailConfiguration : IEntityTypeConfiguration<CartDetail>
    {
        public void Configure(EntityTypeBuilder<CartDetail> builder)
        {
            builder.ToTable("CartDetails");
            builder.HasKey(cd => cd.Id);
            builder.Property(cd => cd.Cost).HasColumnType("decimal(14,2)");
            builder.HasOne(cd => cd.Product).WithMany(p => p.CartDetails).HasForeignKey(cd => cd.ProductId);
            builder.HasOne(cd => cd.Cart).WithMany(c => c.CartDetails).HasForeignKey(cd => cd.CartId);

        }
    }
}
