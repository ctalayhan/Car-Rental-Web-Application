using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Mapping {
    public class UserMapping : IEntityTypeConfiguration<User> {
        public void Configure(EntityTypeBuilder<User> builder) {
            builder.ToTable("Users");
            builder.HasKey(c => c.UserID);
            builder.Property(c => c.UserID).ValueGeneratedOnAdd();

            builder.Property(c => c.FirstName)
                .HasMaxLength(15)
                .HasColumnType("nvarchar")
                .IsRequired();
            builder.Property(c => c.LastName)
                .HasMaxLength(15)
                .HasColumnType("nvarchar")
                .IsRequired();
            builder.Property(c => c.BirthDate)
                .HasColumnType("datetime");
            builder.Property(c => c.Email)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(c => c.Phone)
                .HasColumnType("nvarchar")
                .HasMaxLength(13)
                .IsRequired();
            builder.Property(c => c.Username)
                .HasMaxLength(15)
                .HasColumnType("nvarchar").IsRequired();
            builder.Property(c => c.Password)
                .HasMaxLength(50)
                .HasColumnType("nvarchar")
                .IsRequired();
            builder.Property(c => c.Role)
                .HasColumnType("bit")
                .IsRequired();
        }
    }
}
