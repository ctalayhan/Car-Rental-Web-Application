using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Seeding {
    public static class DiscountSeed  {
        public static void DiscountSeedData(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<Discount>().HasData(
                new Discount {
                DiscountID=1,
                DiscountRatio=0.1m,
            }, new Discount {
                DiscountID = 2,
                DiscountRatio = 0.15m,
            }, new Discount {
                DiscountID = 3,
                DiscountRatio = 0.2m,
            }, new Discount {
                DiscountID = 4,
                DiscountRatio = 0.25m,
            }, new Discount {
                DiscountID = 5,
                DiscountRatio = 0.3m,
            }, new Discount {
                DiscountID = 6,
                DiscountRatio = 0.4m,
            }, new Discount {
                DiscountID = 7,
                DiscountRatio = 0.45m,
            }, new Discount {
                DiscountID = 8,
                DiscountRatio = 0.5m,
            });
        }
    }
}
