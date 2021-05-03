using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Seeding {
    public static class CarStatusTypeSeed {
        public static void CarStatusTypeSeedData(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<CarStatusType>().HasData(
                new CarStatusType {
                StateID = 1,
                StatusDescription = "Satildi",
            }, new CarStatusType {
                StateID = 2,
                StatusDescription = "Serviste",
            }, new CarStatusType {
                StateID = 3,
                StatusDescription = "PerteCikti",
            }, new CarStatusType {
                StateID = 4,
                StatusDescription = "Aktif",
            });
        }
    }
}
