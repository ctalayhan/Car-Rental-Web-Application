using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Mapping {
    public class CarStatusTypeMapping : IEntityTypeConfiguration<CarStatusType>
    {
        public void Configure(EntityTypeBuilder<CarStatusType> builder)
        {
            builder.ToTable("CarStatusType").HasKey(c=>c.StateID);
            builder.Property(c => c.StateID).ValueGeneratedOnAdd();
            builder.Property(c => c.StatusDescription).HasColumnType("nvarchar").HasMaxLength(200);
        }
    }
}
