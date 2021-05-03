
using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Mapping {
    public class DriverLicenseMapping : IEntityTypeConfiguration<DriverLicenseClass> {
        public void Configure(EntityTypeBuilder<DriverLicenseClass> builder)
        {
            builder.ToTable("DriverLicenses");
            builder
                .HasKey(c => c.ClassID);
            builder
                .Property(c => c.ClassID)
                .ValueGeneratedOnAdd();
            builder.Property(x => x.ClassExplanation)
                .HasColumnType("nvarchar")
                .HasMaxLength(30);


        }
    }
}

