using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Mapping {
    public class GearMapping : IEntityTypeConfiguration<Gear>
    {
        public void Configure(EntityTypeBuilder<Gear> builder)
        {
            builder.ToTable("Gears").HasKey(c => c.GearID);
            builder.Property(c => c.GearID).ValueGeneratedOnAdd();
            builder.Property(c => c.GearType).HasColumnName("GearType").HasColumnType("nvarchar").HasMaxLength(10).IsRequired();



        }
    }
}
