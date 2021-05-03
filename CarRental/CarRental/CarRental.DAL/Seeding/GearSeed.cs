using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Seeding {
    public static class GearSeed {
        public static void GearSeedData (this ModelBuilder modelBuilder) {
            modelBuilder.Entity<Gear>().HasData(
                new Gear {
                    GearID = 1,
                    GearType = "Duz",
                },
                new Gear {
                    GearID = 2,
                    GearType = "Otomatik",
                },
                new Gear {
                    GearID = 3,
                    GearType = "Triptonik",
                });
        }
    }
}
