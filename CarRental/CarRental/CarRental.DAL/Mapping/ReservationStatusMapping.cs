using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Mapping {
    public class ReservationStatusMapping : IEntityTypeConfiguration<ReservationStatus> {
        public void Configure(EntityTypeBuilder<ReservationStatus> builder) {
            builder.ToTable("ReservationStatuses");
            builder.HasKey(c => c.ReservationStatusID);
            builder.Property(c => c.ReservationStatusID).ValueGeneratedOnAdd();
            builder.Property(c => c.Description).HasColumnType("nvarchar").HasMaxLength(20).IsRequired();
        }
    }
}
