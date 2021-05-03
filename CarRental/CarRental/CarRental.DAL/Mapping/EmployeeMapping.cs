using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Mapping {
    public class EmployeeMapping : IEntityTypeConfiguration<Employee> {
        public void Configure(EntityTypeBuilder<Employee> builder) {
            builder.ToTable("Employees");
            builder.HasKey(c => c.EmployeeID);
            builder.Property(c => c.EmployeeID)
                .ValueGeneratedOnAdd();
            builder.Property(c => c.FirstName)
                .HasMaxLength(15)
                .HasColumnType("nvarchar")
                .IsRequired();
            builder.Property(c => c.LastName)
                .HasMaxLength(15)
                .HasColumnType("nvarchar")
                .IsRequired();
            builder.Property(c => c.Email)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(c => c.BloodType)
                .HasColumnType("nvarchar")
                .HasMaxLength(15)
                .IsRequired();
            builder.Property(c => c.Education)
                .HasColumnType("nvarchar")
                .HasMaxLength(40)
                .IsRequired();
            builder.Property(c => c.BirthDate)
                .HasColumnType("date");
            builder.Property(c => c.Phone)
                .HasColumnType("nvarchar")
                .HasMaxLength(13)
                .IsRequired();
            builder.Property(c => c.Address)
                .HasColumnType("nvarchar")
                .HasMaxLength(150);
            builder.Property(c => c.Image).HasColumnName("Image").HasColumnType("image");
            builder.Property(c => c.Summary)
                .HasColumnType("nvarchar")
                .HasMaxLength(1500);
            builder.HasOne(c => c.ReportsTo)
                .WithMany(c => c.Employees)
            .HasForeignKey(c => c.ReportsToID);
            builder.HasMany(c => c.Employees)
            .WithOne(c => c.ReportsTo)
            .HasForeignKey(c => c.ReportsToID);

        }
    }
}
