using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Seeding {
     public static class ReservationSeed  {
        public static void ReservationSeedData(this ModelBuilder modelBuilder) {
			modelBuilder.Entity<Reservation>().HasData(
				new Reservation {
				ReservationID = 1,
				UserID = 1,
				StatusID = 1,
				ReservationDate = DateTime.ParseExact("2020/11/18", "yyyy/MM/dd", null),
				EmployeeID = 5,
			},
				new Reservation {
					ReservationID = 2,
					UserID = 2,
					StatusID = 2,
					ReservationDate = DateTime.ParseExact("2020/11/17", "yyyy/MM/dd", null),
					EmployeeID = 6,
				},
				new Reservation {
					ReservationID = 3,
					UserID = 3,
					StatusID = 3,
					ReservationDate = DateTime.ParseExact("2020/11/16", "yyyy/MM/dd", null),
					EmployeeID = 7,
				},
				new Reservation {
					ReservationID = 4,
					UserID = 4,
					StatusID = 1,
					ReservationDate = DateTime.ParseExact("2020/11/15", "yyyy/MM/dd", null),
					EmployeeID = 8,
				},
				new Reservation {
					ReservationID = 5,
					UserID = 5,
					StatusID = 1,
					ReservationDate = DateTime.ParseExact("2020/11/14", "yyyy/MM/dd", null),
					EmployeeID = 5,
				},
				new Reservation {
					ReservationID = 6,
					UserID = 6,
					StatusID = 1,
					ReservationDate = DateTime.ParseExact("2020/11/13", "yyyy/MM/dd", null),
					EmployeeID = 6,
				});
		}       
    }
}
