using CarRental.DAL.Seeding;
using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Mapping {
    public class BrandModelDetailMapping : IEntityTypeConfiguration<BrandModelDetail>
    {
        public void Configure(EntityTypeBuilder<BrandModelDetail> builder)
        {
            builder.ToTable("BrandModelDetails").HasKey(c => c.BrandModelDetailID);

            builder.Property(c => c.BrandModelDetailID).ValueGeneratedOnAdd();
            builder.Property(c => c.BrandRefID).IsRequired().HasColumnType("int");
            builder.Property(c => c.ModelYear).HasColumnType("date").HasColumnName("ModelYear").IsRequired();
            builder.Property(c => c.Image).HasColumnName("Image").HasColumnType("image");
            builder.HasOne(c => c.CarBrand).WithMany(c => c.BrandModelDetails).HasForeignKey(c => c.BrandRefID);
        }
    }
}