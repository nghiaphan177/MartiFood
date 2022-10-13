using MartiFood_API.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MartiFood_API.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.OrderDate);

            builder.Property(x => x.ShipEmail).IsRequired().IsUnicode(false).HasMaxLength(50);

            builder.Property(x => x.ShipAddress).IsRequired().HasMaxLength(200);

            builder.Property(x => x.ShipName).IsRequired().HasMaxLength(200);

            builder.Property(x => x.ShipPhoneNumber).IsRequired().HasMaxLength(200);

            builder.HasOne(o => o.AppUser).WithMany(u => u.Orders).HasForeignKey(o => o.UserId);

        }


    }
}