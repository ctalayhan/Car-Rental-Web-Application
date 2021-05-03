using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Mapping {
    public class CarStatusMapping : IEntityTypeConfiguration<CarStatus>
    {
        public void Configure(EntityTypeBuilder<CarStatus> builder)
        {
            builder.ToTable("CarStatuses");
            builder.Property(c => c.DateofEntry).IsRequired().HasColumnType("Date");
            builder.Property(c => c.ReleaseDate).IsRequired().HasColumnType("Date");

            //Relation
            builder.HasKey(ck => new { ck.CarID, ck.StatusID });
            builder.HasOne(c => c.Car).WithMany(c => c.CarStatus).HasForeignKey(c => c.CarID);
            builder.HasOne(c => c.CarStatusType).WithMany(c => c.CarStatus).HasForeignKey(c => c.StatusID);
        }
    }
}
