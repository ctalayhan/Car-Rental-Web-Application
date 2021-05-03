using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Mapping {
    public class CarMapping : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars").HasKey(c => c.CarID);
            builder.Property(c => c.CarID).ValueGeneratedOnAdd();
            builder.Property(c => c.PlateNo).IsRequired().HasColumnType("nvarchar").HasMaxLength(10);
            builder.Property(c => c.ChassisNo).IsRequired().HasColumnType("nvarchar").HasMaxLength(17);
            builder.Property(c => c.GearID).IsRequired().HasColumnType("int");
            builder.Property(c => c.BrandModelDetailID).IsRequired().HasColumnType("int");
            builder.Property(c => c.FuelTypeID).IsRequired().HasColumnType("int");
            builder.Property(c => c.DailyFee).IsRequired().HasColumnType("money");

            // Relation
            builder.HasOne(c => c.Gear).WithMany(c => c.Cars).HasForeignKey(c => c.GearID);
            builder.HasOne(c => c.FuelType).WithMany(c => c.Cars).HasForeignKey(c => c.FuelTypeID);
            builder.HasOne(c => c.BrandModelDetail).WithMany(c => c.Cars).HasForeignKey(c => c.BrandModelDetailID);
        }
    }
}
