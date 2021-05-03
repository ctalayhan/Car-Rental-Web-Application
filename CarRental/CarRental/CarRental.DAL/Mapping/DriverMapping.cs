using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Mapping {
    public class DriverMapping : IEntityTypeConfiguration<Driver> {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.ToTable("Drivers");
            builder
                .HasKey(c => c.DriverID);
            builder
                .Property(c => c.DriverID)
                .ValueGeneratedOnAdd();
            builder.Property(x => x.FirstName)
                .HasColumnType("nvarchar")
                .HasMaxLength(20)
                .IsRequired();
            builder.Property(x => x.LastName)
                .HasColumnType("nvarchar")
                .HasMaxLength(25)
                .IsRequired();
            builder.Property(c => c.BirthDate)
                .HasColumnType("date")
                .IsRequired();
            builder.Property(c => c.Email)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(c => c.PhoneNumber).HasColumnType("nvarchar")
                .HasMaxLength(13)
                .IsRequired();
            builder.Property(c => c.Address)
                .HasColumnType("nvarchar")
                .HasMaxLength(150).IsRequired();
            builder.Property(c => c.TCKNO)
                .HasColumnType("nvarchar")
                .HasMaxLength(11).IsRequired();
            builder.Property(p => p.Approval)
                 .HasColumnType("bit")
                 .IsRequired()
                 .HasDefaultValue(false);

            builder.HasOne(c => c.DriverLicenseClass).WithMany(c => c.Drivers).HasForeignKey(c => c.ClassID);
        }
    }
}
