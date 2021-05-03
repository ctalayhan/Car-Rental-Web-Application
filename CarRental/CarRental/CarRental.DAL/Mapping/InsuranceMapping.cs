using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Mapping {
    public class InsuranceMapping : IEntityTypeConfiguration<Insurance>
    {
        public void Configure(EntityTypeBuilder<Insurance> builder)
        {
            builder.ToTable("Insurances");
            builder.HasKey(x => x.InsuranceID);
            builder.Property(x => x.Description).HasColumnType("nvarchar").HasMaxLength(150).IsRequired();
        }
    }
}
