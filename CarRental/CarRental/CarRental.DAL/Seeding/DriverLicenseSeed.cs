using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Seeding {
    public static class DriverLicenseSeed  {
        public static void DriverLicenseSeedData(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<DriverLicenseClass>().HasData(
                new DriverLicenseClass {
                    ClassID = 1,
                    ClassExplanation = "A",
                },
                new DriverLicenseClass {
                    ClassID = 2,
                    ClassExplanation = "A1",
                },
                new DriverLicenseClass {
                    ClassID = 3,
                    ClassExplanation = "A2",
                },
                new DriverLicenseClass {
                    ClassID = 4,
                    ClassExplanation = "B",
                },
                new DriverLicenseClass {
                    ClassID = 5,
                    ClassExplanation = "B1",
                },
                new DriverLicenseClass {
                    ClassID = 6,
                    ClassExplanation = "BE",
                },
                new DriverLicenseClass {
                    ClassID = 7,
                    ClassExplanation = "C",
                },
                new DriverLicenseClass {
                    ClassID = 8,
                    ClassExplanation = "C1",
                },
                new DriverLicenseClass {
                    ClassID = 9,
                    ClassExplanation = "C1E",
                },
                new DriverLicenseClass {
                    ClassID = 10,
                    ClassExplanation = "CE",
                },
                new DriverLicenseClass {
                    ClassID = 11,
                    ClassExplanation = "D",
                },
                new DriverLicenseClass {
                    ClassID = 12,
                    ClassExplanation = "D1",
                },
                new DriverLicenseClass {
                    ClassID = 13,
                    ClassExplanation = "D1E",
                },
                new DriverLicenseClass {
                    ClassID = 14,
                    ClassExplanation = "DE",
                },
                new DriverLicenseClass {
                    ClassID = 15,
                    ClassExplanation = "F",
                },
                new DriverLicenseClass {
                    ClassID = 16,
                    ClassExplanation = "G",
                },
                new DriverLicenseClass {
                    ClassID = 17,
                    ClassExplanation = "M",
                });
        }
    }
}
