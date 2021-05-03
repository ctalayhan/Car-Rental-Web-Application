using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Mapping {
    public class ReservationDetailMapping : IEntityTypeConfiguration<ReservationDetail>
    {
        public void Configure(EntityTypeBuilder<ReservationDetail> builder)
        {
            builder.ToTable("ReservationDetails");
            builder.Property(x => x.DailyFee).HasColumnType("money").IsRequired();
            builder.Property(x => x.DayCount).HasColumnType("smallint");
            builder.Property(x => x.DeliveryDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.ReturnDate).HasColumnType("datetime");
            builder.Property(x => x.DeliveryLocation).HasColumnType("nvarchar").HasMaxLength(300).IsRequired();
            builder.Property(x => x.ReturnLocation).HasColumnType("nvarchar").HasMaxLength(300);

            // Relation
            builder.HasKey(cr => new { cr.CarID, cr.ReservationID });
            builder.HasOne(x => x.Car).WithMany(x => x.ReservationDetails).HasForeignKey(x => x.CarID);
            builder.HasOne(x => x.Reservation).WithMany(x => x.ReservationDetails).HasForeignKey(x => x.ReservationID);
            builder.HasOne(x => x.Discount).WithMany(x => x.ReservationDetails).HasForeignKey(x => x.DiscountID);
            builder.HasOne(x => x.Insurance).WithMany(x => x.ReservationDetails).HasForeignKey(x => x.InsuranceID);
            builder.HasOne(x => x.Driver).WithMany(x => x.ReservationDetails).HasForeignKey(x => x.DriverID);
            builder.HasOne(x => x.Contract).WithMany(x => x.ReservationDetails).HasForeignKey(x => x.ContractID );
        }
    }
}
