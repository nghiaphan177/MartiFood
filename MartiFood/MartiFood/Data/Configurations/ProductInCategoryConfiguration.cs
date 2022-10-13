﻿using MartiFood_API.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MartiFood_API.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(pc => new { pc.CategoryId, pc.ProductId });

            builder.ToTable("ProductInCategories");

            builder.HasOne(pc => pc.Product).WithMany(p => p.ProductInCategories)
                .HasForeignKey(pc => pc.ProductId);

            builder.HasOne(pc => pc.Category).WithMany(c => c.ProductInCategories)
              .HasForeignKey(pc => pc.CategoryId);
        }
    }
}
