using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Mapping {
    public class FuelTypeMapping : IEntityTypeConfiguration<FuelType>
    {
        public void Configure(EntityTypeBuilder<FuelType> builder)
        {
            builder.ToTable("FuelTypes").HasKey(c => c.FuelTypeID);
            builder.Property(c => c.FuelTypeID).ValueGeneratedOnAdd();
            builder.Property(c => c.FuelTypeName).IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            builder.Property(c => c.Description).HasColumnType("nvarchar").HasMaxLength(50);

        }
    }
}
