using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Mapping {
    public class CarHistoryMapping : IEntityTypeConfiguration<CarHistory>
    {
        public void Configure(EntityTypeBuilder<CarHistory> builder)
        {
            builder.ToTable("CarHistories").HasKey(c => c.ID);
            builder.Property(c => c.ID).ValueGeneratedOnAdd();
            builder.Property(c => c.CarID).IsRequired();
            builder.Property(c => c.InspectionDate).HasColumnType("date").HasColumnName("InspectionDate").IsRequired();
            builder.Property(c => c.VisaDate).HasColumnType("date").HasColumnName("VisaDate").IsRequired();

            builder.HasOne(c => c.Car).WithMany(d => d.CarHistories).HasForeignKey(c => c.CarID); // Nerden geldiğine bak


        }
    }
}
