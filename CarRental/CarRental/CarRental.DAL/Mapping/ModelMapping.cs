using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Mapping {
    public class ModelMapping : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.ToTable("Models").HasKey(c => c.ModelID);
            builder.Property(c => c.ModelID).ValueGeneratedOnAdd();
            builder.Property(c => c.ModelName).HasColumnName("ModelName").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.HasOne(x => x.CarBrand).WithMany(x => x.Models).HasForeignKey(x => x.BrandRefID);


        }
    }
}
