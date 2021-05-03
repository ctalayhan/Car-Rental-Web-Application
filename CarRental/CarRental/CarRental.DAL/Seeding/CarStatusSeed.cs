using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Seeding {
    public static class CarStatusSeed {
        public static void CarStatusSeedData(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<CarStatus>().HasData(
                new CarStatus {
                    CarID = 1,
                    StatusID = 4,
                    DateofEntry = DateTime.ParseExact("2020/10/28", "yyyy/MM/dd", null),
                },
                new CarStatus {
                    CarID = 2,
                    StatusID = 4,
                    DateofEntry = DateTime.ParseExact("2020/01/05", "yyyy/MM/dd", null),
                },
                new CarStatus {
                    CarID = 3,
                    StatusID = 4,
                    DateofEntry = DateTime.ParseExact("2020/09/04", "yyyy/MM/dd", null),
                },
                new CarStatus {
                    CarID = 4,
                    StatusID = 4,
                    DateofEntry = DateTime.ParseExact("2019/10/28", "yyyy/MM/dd", null),
                },
                new CarStatus {
                    CarID = 5,
                    StatusID = 4,
                    DateofEntry = DateTime.ParseExact("2020/10/28", "yyyy/MM/dd", null),
                },
                new CarStatus {
                    CarID = 6,
                    StatusID = 4,
                    DateofEntry = DateTime.ParseExact("2020/05/05", "yyyy/MM/dd", null),
                },
                new CarStatus {
                    CarID = 7,
                    StatusID = 4,
                    DateofEntry = DateTime.ParseExact("2020/05/05", "yyyy/MM/dd", null),
                },
                new CarStatus {
                    CarID = 8,
                    StatusID = 4,
                    DateofEntry = DateTime.ParseExact("2020/07/14", "yyyy/MM/dd", null),
                },
                new CarStatus {
                    CarID = 9,
                    StatusID = 4,
                    DateofEntry = DateTime.ParseExact("2020/07/14", "yyyy/MM/dd", null),
                },
                new CarStatus {
                    CarID = 10,
                    StatusID = 4,
                    DateofEntry = DateTime.ParseExact("2020/06/13", "yyyy/MM/dd", null),
                },
                new CarStatus {
                    CarID = 11,
                    StatusID = 4,
                    DateofEntry = DateTime.ParseExact("2020/06/13", "yyyy/MM/dd", null),
                },
                new CarStatus {
                    CarID = 12,
                    StatusID = 4,
                    DateofEntry = DateTime.ParseExact("2020/06/14", "yyyy/MM/dd", null),
                },
                new CarStatus {
                    CarID = 13,
                    StatusID = 4,
                    DateofEntry = DateTime.ParseExact("2020/03/14", "yyyy/MM/dd", null),
                },
                new CarStatus {
                    CarID = 14,
                    StatusID = 4,
                    DateofEntry = DateTime.ParseExact("2018/01/21", "yyyy/MM/dd", null),
                },
                new CarStatus {
                    CarID = 15,
                    StatusID = 4,
                    DateofEntry = DateTime.ParseExact("2019/01/28", "yyyy/MM/dd", null),
                },
                new CarStatus {
                    CarID = 16,
                    StatusID = 4,
                    DateofEntry = DateTime.ParseExact("2020/02/22", "yyyy/MM/dd", null),
                },
                new CarStatus {
                    CarID = 17,
                    StatusID = 2,
                    DateofEntry = DateTime.ParseExact("2020/02/22", "yyyy/MM/dd", null),
                },
                new CarStatus {
                    CarID = 18,
                    StatusID = 2,
                    DateofEntry = DateTime.ParseExact("2017/11/15", "yyyy/MM/dd", null),
                },
                new CarStatus {
                    CarID = 19,
                    StatusID = 1,
                    DateofEntry = DateTime.ParseExact("2020/02/08", "yyyy/MM/dd", null),
                },
                new CarStatus {
                    CarID = 20,
                    StatusID = 3,
                    DateofEntry = DateTime.ParseExact("2020/02/08", "yyyy/MM/dd", null),
                }
);
        }
    }
}
