using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Seeding {
    public static class ModelSeed {
        public static void ModelSeedData (this ModelBuilder modelBuilder) {
            modelBuilder.Entity<Model>().HasData(
                new Model {
                    ModelID = 1,
                    BrandRefID = 1,
                    ModelName = "A3 Sedan 1.5 TFSI",
                },
                new Model {
                    ModelID = 2,
                    BrandRefID = 1,
                    ModelName = "A3 Sportback 1.5 TFSI",
                },
                new Model {
                    ModelID = 3,
                    BrandRefID = 1,
                    ModelName = "A3 Sedan 1.0 TFSI",
                },
                new Model {
                    ModelID = 4,
                    BrandRefID = 1,
                    ModelName = "A4 Sedan 2.0 TDI",
                },
                new Model {
                    ModelID = 5,
                    BrandRefID = 1,
                    ModelName = "A4 Sedan 2.0 TFSI",
                },
                new Model {
                    ModelID = 6,
                    BrandRefID = 2,
                    ModelName = "A4 Avant 1.4 Design",
                },
                new Model {
                    ModelID = 7,
                    BrandRefID = 2,
                    ModelName = "Fiesta 1.0 Titanium AT",
                },
                new Model {
                    ModelID = 8,
                    BrandRefID = 2,
                    ModelName = "Fiesta 1.5 TDCi Titanium",
                },
                new Model {
                    ModelID = 9,
                    BrandRefID = 2,
                    ModelName = "Focus 1.5 Titanium",
                },
                new Model {
                    ModelID = 10,
                    BrandRefID = 2,
                    ModelName = "Focus 1.5 Titanium AT",
                },
                new Model {
                    ModelID = 11,
                    BrandRefID = 2,
                    ModelName = "Focus 1.5 Trend X",
                },
                new Model {
                    ModelID = 12,
                    BrandRefID = 2,
                    ModelName = "Focus 1.5 Trend X AT",
                },
                new Model {
                    ModelID = 13,
                    BrandRefID = 2,
                    ModelName = "EcoSport 1.0 ST/Line AT",
                },
                new Model {
                    ModelID = 14,
                    BrandRefID = 3,
                    ModelName = "EcoSport 1.0 Syle AT",
                },
                new Model {
                    ModelID = 15,
                    BrandRefID = 3,
                    ModelName = "C3 1.2 Feel",
                },
                new Model {
                    ModelID = 16,
                    BrandRefID = 3,
                    ModelName = "C3 1.2 Feel AT",
                },
                new Model {
                    ModelID = 17,
                    BrandRefID = 3,
                    ModelName = "C3 1.2 Shine AT",
                },
                new Model {
                    ModelID = 18,
                    BrandRefID = 3,
                    ModelName = "C3 Picasso 1.4 e-HDi Confort BMP STT",
                },
                new Model {
                    ModelID = 19,
                    BrandRefID = 3,
                    ModelName = "C3 Picasso 1.6 e-HDi Confort BMP6 STT",
                },
                new Model {
                    ModelID = 20,
                    BrandRefID = 4,
                    ModelName = "S60 1.5 T3 Advance",
                },
                new Model {
                    ModelID = 21,
                    BrandRefID = 4,
                    ModelName = "S60 1.5 T3 Premium",
                },
                new Model {
                    ModelID = 22,
                    BrandRefID = 4,
                    ModelName = "S60 1.5 T3 R-Design Plus",
                });
        }
    }
}
