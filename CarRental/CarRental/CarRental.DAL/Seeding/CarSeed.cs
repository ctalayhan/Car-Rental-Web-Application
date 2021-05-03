using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Seeding {
    public static class CarSeed {
        public static void CarSeedData(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<Car>().HasData(
                new Car {
                    CarID = 1,
                    PlateNo = "34KUC88",
                    ChassisNo = "BC83493824XDB45S2",
                    GearID = 1,
                    BrandModelDetailID = 1,
                    FuelTypeID = 1,
                },
                new Car {
                    CarID = 2,
                    PlateNo = "34KTC91",
                    ChassisNo = "AC83493324DFB25S1",
                    GearID = 2,
                    BrandModelDetailID = 2,
                    FuelTypeID = 3,
                },
                new Car {
                    CarID = 3,
                    PlateNo = "34ACC72",
                    ChassisNo = "CA83293824XDB41S2",
                    GearID = 1,
                    BrandModelDetailID = 3,
                    FuelTypeID = 1,
                },
                new Car {
                    CarID = 4,
                    PlateNo = "34KRC50",
                    ChassisNo = "DC83493324DFB40S1",
                    GearID = 2,
                    BrandModelDetailID = 4,
                    FuelTypeID = 1,
                },
                new Car {
                    CarID = 5,
                    PlateNo = "33AUC27",
                    ChassisNo = "EC83443814XAB45S1",
                    GearID = 1,
                    BrandModelDetailID = 5,
                    FuelTypeID = 2,
                },
                new Car {
                    CarID = 6,
                    PlateNo = "33AKM31",
                    ChassisNo = "FC83483324DFB40S1",
                    GearID = 2,
                    BrandModelDetailID = 6,
                    FuelTypeID = 1,
                },
                new Car {
                    CarID = 7,
                    PlateNo = "34BDR48",
                    ChassisNo = "GC83443814WAB45S1",
                    GearID = 1,
                    BrandModelDetailID = 7,
                    FuelTypeID = 2,
                },
                new Car {
                    CarID = 8,
                    PlateNo = "34KSK34",
                    ChassisNo = "HC86793814BAW45S1",
                    GearID = 2,
                    BrandModelDetailID = 8,
                    FuelTypeID = 1,
                },
                new Car {
                    CarID = 9,
                    PlateNo = "34TRM28",
                    ChassisNo = "IK86753814SRD45S1",
                    GearID = 1,
                    BrandModelDetailID = 9,
                    FuelTypeID = 2,
                },
                new Car {
                    CarID = 10,
                    PlateNo = "34MGL77",
                    ChassisNo = "JN86756814SRD45S1",
                    GearID = 1,
                    BrandModelDetailID = 10,
                    FuelTypeID = 3,
                },
                new Car {
                    CarID = 11,
                    PlateNo = "34ZYT66",
                    ChassisNo = "KK86753814SRD45S1",
                    GearID = 3,
                    BrandModelDetailID = 11,
                    FuelTypeID = 4,
                },
                new Car {
                    CarID = 12,
                    PlateNo = "34RRT65",
                    ChassisNo = "LA86357814SRD45S1",
                    GearID = 2,
                    BrandModelDetailID = 12,
                    FuelTypeID = 2,
                },
                new Car {
                    CarID = 13,
                    PlateNo = "34APR17",
                    ChassisNo = "MT86357814SRD45S1",
                    GearID = 2,
                    BrandModelDetailID = 13,
                    FuelTypeID = 1,
                },
                new Car {
                    CarID = 14,
                    PlateNo = "34XPX11",
                    ChassisNo = "NL86357888SRD45S1",
                    GearID = 1,
                    BrandModelDetailID = 14,
                    FuelTypeID = 4,
                },
                new Car {
                    CarID = 15,
                    PlateNo = "34LMN18",
                    ChassisNo = "OT86357877SRD45S1",
                    GearID = 3,
                    BrandModelDetailID = 15,
                    FuelTypeID = 2,
                },
                new Car {
                    CarID = 16,
                    PlateNo = "34NLM33",
                    ChassisNo = "PO86357681SRD45S1",
                    GearID = 3,
                    BrandModelDetailID = 16,
                    FuelTypeID = 2,
                },
                new Car {
                    CarID = 17,
                    PlateNo = "34ALO39",
                    ChassisNo = "RI36557681UGR45S1",
                    GearID = 1,
                    BrandModelDetailID = 17,
                    FuelTypeID = 4,
                },
                new Car {
                    CarID = 18,
                    PlateNo = "34NLM81",
                    ChassisNo = "SU86357681ERD45Y1",
                    GearID = 3,
                    BrandModelDetailID = 18,
                    FuelTypeID = 2,
                },
                new Car {
                    CarID = 19,
                    PlateNo = "34MHR55",
                    ChassisNo = "TE86357551DYY45Y1",
                    GearID = 3,
                    BrandModelDetailID = 19,
                    FuelTypeID = 2,
                },
                new Car {
                    CarID = 20,
                    PlateNo = "34NCN49",
                    ChassisNo = "UJ86357681THC45Y1",
                    GearID = 1,
                    BrandModelDetailID = 20,
                    FuelTypeID = 4,
                });
        }
    }
}
