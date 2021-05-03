using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Mapping {
    public class ReservationMapping : IEntityTypeConfiguration<Reservation> {
        public void Configure(EntityTypeBuilder<Reservation> builder) {
            builder.ToTable("Reservations");
            builder.HasKey(c => c.ReservationID);
            builder.Property(c => c.ReservationID)
                .ValueGeneratedOnAdd();
            builder.Property(c => c.ReservationDate)
                .HasColumnType("datetime")
                .IsRequired();

            builder.HasOne(c => c.User).WithMany(c => c.Reservations).HasForeignKey(c => c.UserID);
            builder.HasOne(c => c.ReservationStatus).WithMany(c => c.Reservations).HasForeignKey(c => c.StatusID);
            builder.HasOne(c => c.Employee).WithMany(c => c.Reservations).HasForeignKey(c => c.EmployeeID);

        }
    }
}
