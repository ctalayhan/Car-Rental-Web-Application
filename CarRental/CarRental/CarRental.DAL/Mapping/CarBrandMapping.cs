using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Mapping {
    public class CarBrandMapping : IEntityTypeConfiguration<CarBrand>
    {
        public void Configure(EntityTypeBuilder<CarBrand> builder)
        {
            builder.ToTable("CarBrands").HasKey(c => c.BrandID);
            builder.Property(c => c.BrandID).ValueGeneratedOnAdd();
            builder.Property(c => c.BrandName).HasColumnType("nvarchar").HasColumnName("BrandName").HasMaxLength(20);
        }
    }
}
