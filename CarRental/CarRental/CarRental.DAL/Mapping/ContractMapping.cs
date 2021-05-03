using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Mapping {
    public class ContractMapping : IEntityTypeConfiguration<Contract> {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.ToTable("Contracts");
            builder
                .HasKey(c => c.ContractID);
            builder
                .Property(c => c.ContractID)
                .ValueGeneratedOnAdd();
            builder.Property(x => x.ContractType)
                .HasColumnType("nvarchar")
                .HasMaxLength(300);
        }
    }
}
