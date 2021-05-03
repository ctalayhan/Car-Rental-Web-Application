using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Seeding {
    public static class CarBrandSeed {
        public static void CarBrandSeedData(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<CarBrand>().HasData(new CarBrand {
                BrandID=1,
                BrandName="Audi",                
            }, new CarBrand {
                BrandID = 2,
                BrandName = "Ford",
            }, new CarBrand {
                BrandID = 3,
                BrandName = "Citroen",
            }, new CarBrand {
                BrandID = 4,
                BrandName = "Volvo",
            }

            );
        }
    }
}
