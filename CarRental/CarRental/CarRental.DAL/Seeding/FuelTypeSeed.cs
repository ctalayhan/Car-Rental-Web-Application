using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Seeding {
    public static class FuelTypeSeed {
        public static void FuelTypeSeedData(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<FuelType>().HasData(
              new FuelType {
                  FuelTypeID = 1,
                  FuelTypeName = "Benzin",
                  Description = "Benzinle Calisir",
              },
              new FuelType {
                  FuelTypeID = 2,
                  FuelTypeName = "Dizel",
                  Description = "Mazotla Calisir",
              },
              new FuelType {
                  FuelTypeID = 3,
                  FuelTypeName = "LPG",
                  Description = "Gazla Calisir",
              },
              new FuelType {
                  FuelTypeID = 4,
                  FuelTypeName = "Hibrit",
                  Description = "Elektrik ve Benzinle Calisir",
              });
        }
    }
}
