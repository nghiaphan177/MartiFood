﻿using MartiFood_API.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MartiFood_API.Data.Configurations
{
    public class SlideConfiguration : IEntityTypeConfiguration<Slide>
    {
        public void Configure(EntityTypeBuilder<Slide> builder)
        {
            builder.ToTable("Slides");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();

            builder.Property(x => x.Description).HasMaxLength(200).IsRequired();

            builder.Property(x => x.Url).HasMaxLength(200).IsRequired();

            builder.Property(x => x.Image).HasMaxLength(200).IsRequired();
        }


    }
}
