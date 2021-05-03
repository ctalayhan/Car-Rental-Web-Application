using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Seeding {
    public static class BrandModelDetailSeed {
        public static void BrandModelDetailSeedData(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<BrandModelDetail>().HasData(
                new BrandModelDetail {
                BrandModelDetailID=1,
                BrandRefID=1,
                ModelYear= DateTime.ParseExact("2019", "yyyy", null),
            }, new BrandModelDetail {
                BrandModelDetailID = 2,
                BrandRefID = 1,
                ModelYear = DateTime.ParseExact("2019", "yyyy", null),

            }, new BrandModelDetail {
                BrandModelDetailID = 3,
                BrandRefID = 1,
                ModelYear = DateTime.ParseExact("2019", "yyyy", null),
            }, new BrandModelDetail {
                BrandModelDetailID = 4,
                BrandRefID = 1,
                ModelYear = DateTime.ParseExact("2018", "yyyy", null),
            }, new BrandModelDetail {

                BrandModelDetailID = 5,
                BrandRefID = 1,
                ModelYear = DateTime.ParseExact("2020", "yyyy", null),
            }, new BrandModelDetail {

                BrandModelDetailID = 6,
                BrandRefID = 2,
                ModelYear = DateTime.ParseExact("2019", "yyyy", null),
            }, new BrandModelDetail {

                BrandModelDetailID = 7,
                BrandRefID = 2,
                ModelYear = DateTime.ParseExact("2018", "yyyy", null),
            }, new BrandModelDetail {

                BrandModelDetailID = 8,
                BrandRefID = 2,
                ModelYear = DateTime.ParseExact("2019", "yyyy", null),
            }, new BrandModelDetail {

                BrandModelDetailID = 9,
                BrandRefID = 2,
                ModelYear = DateTime.ParseExact("2019", "yyyy", null),
            }, new BrandModelDetail {

                BrandModelDetailID = 10,
                BrandRefID = 2,
                ModelYear = DateTime.ParseExact("2020", "yyyy", null),
            }, new BrandModelDetail {

                BrandModelDetailID = 11,
                BrandRefID = 2,
                ModelYear = DateTime.ParseExact("2019", "yyyy", null),
            }, new BrandModelDetail {

                BrandModelDetailID = 12,
                BrandRefID = 2,
                ModelYear = DateTime.ParseExact("2020", "yyyy", null),
            }, new BrandModelDetail {

                BrandModelDetailID = 13,
                BrandRefID = 2,
                ModelYear = DateTime.ParseExact("2019", "yyyy", null),
            }, new BrandModelDetail {

                BrandModelDetailID = 14,
                BrandRefID = 3,
                ModelYear = DateTime.ParseExact("2017", "yyyy", null),
            }, new BrandModelDetail {

                BrandModelDetailID = 15,
                BrandRefID = 3,
                ModelYear = DateTime.ParseExact("2019", "yyyy", null),
            }, new BrandModelDetail {

                BrandModelDetailID = 16,
                BrandRefID = 3,
                ModelYear = DateTime.ParseExact("2020", "yyyy", null),
            }, new BrandModelDetail {

                BrandModelDetailID = 17,
                BrandRefID = 3,
                ModelYear = DateTime.ParseExact("2020", "yyyy", null),
            }, new BrandModelDetail {

                BrandModelDetailID = 18,
                BrandRefID = 4,
                ModelYear = DateTime.ParseExact("2016", "yyyy", null),
            }, new BrandModelDetail {

                BrandModelDetailID = 19,
                BrandRefID = 4,
                ModelYear = DateTime.ParseExact("2020", "yyyy", null),
            }, new BrandModelDetail {

                BrandModelDetailID = 20,
                BrandRefID = 4,
                ModelYear = DateTime.ParseExact("2019", "yyyy", null),
            }
            );
        }
    }
}
