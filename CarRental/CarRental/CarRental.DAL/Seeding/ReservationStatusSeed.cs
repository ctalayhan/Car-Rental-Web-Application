using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Seeding {
    public static class ReservationStatusSeed  {
        public static void ReservationStatusSeedData(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<ReservationStatus>().HasData(
                new ReservationStatus {
                    ReservationStatusID = 1,
                    Description = "Onaylandi",
                }, new ReservationStatus {
                    ReservationStatusID = 2,
                    Description = "Reddedildi",
                }, new ReservationStatus {
                    ReservationStatusID = 3,
                    Description = "Iptal",
                });
        }
    }
}
