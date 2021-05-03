using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Seeding {
    public static class InsuranceSeed{
        public static void InsuranceSeedData(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<Insurance>().HasData(
                new Insurance {
                    InsuranceID = 1,
                    Description = "Standart : Dis hasar",
                }, new Insurance {
                    InsuranceID = 2,
                    Description = "Premium : Dis hasar + iç hasar + hirsizlik",
                }, new Insurance {
                    InsuranceID = 3,
                    Description = "Deluxe : Full teminat",
                });
        }
    }
}
