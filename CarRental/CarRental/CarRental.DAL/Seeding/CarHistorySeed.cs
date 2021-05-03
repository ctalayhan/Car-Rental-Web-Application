using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Seeding {
    public static class CarHistorySeed {
        public static void CarHistorySeedData(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<CarHistory>().HasData(
                new CarHistory {
                ID = 1,
                CarID = 1,
                InspectionDate = DateTime.ParseExact("15/02/2021", "dd/MM/yyyy", null),
                VisaDate = DateTime.ParseExact("06/05/2021", "dd/MM/yyyy", null),
            },
                new CarHistory {
                    ID = 2,
                    CarID = 2,
                    InspectionDate = DateTime.ParseExact("15/02/2021", "dd/MM/yyyy", null),
                    VisaDate = DateTime.ParseExact("06/05/2021", "dd/MM/yyyy", null),
                },
                new CarHistory {
                    ID = 3,
                    CarID = 3,
                    InspectionDate = DateTime.ParseExact("15/02/2021", "dd/MM/yyyy", null),
                    VisaDate = DateTime.ParseExact("06/05/2021", "dd/MM/yyyy", null),
                },
                new CarHistory {
                    ID = 4,
                    CarID = 4,
                    InspectionDate = DateTime.ParseExact("15/03/2021", "dd/MM/yyyy", null),
                    VisaDate = DateTime.ParseExact("06/06/2021", "dd/MM/yyyy", null),
                },
                new CarHistory {
                    ID = 5,
                    CarID = 5,
                    InspectionDate = DateTime.ParseExact("15/03/2021", "dd/MM/yyyy", null),
                    VisaDate = DateTime.ParseExact("06/06/2021", "dd/MM/yyyy", null),
                },
                new CarHistory {
                    ID = 6,
                    CarID = 6,
                    InspectionDate = DateTime.ParseExact("15/03/2021", "dd/MM/yyyy", null),
                    VisaDate = DateTime.ParseExact("06/06/2021", "dd/MM/yyyy", null),
                },
                new CarHistory {
                    ID = 7,
                    CarID = 7,
                    InspectionDate = DateTime.ParseExact("15/04/2021", "dd/MM/yyyy", null),
                    VisaDate = DateTime.ParseExact("06/08/2021", "dd/MM/yyyy", null),
                },
                new CarHistory {
                    ID = 8,
                    CarID = 8,
                    InspectionDate = DateTime.ParseExact("15/04/2021", "dd/MM/yyyy", null),
                    VisaDate = DateTime.ParseExact("06/08/2021", "dd/MM/yyyy", null),
                },
                new CarHistory {
                    ID = 9,
                    CarID = 9,
                    InspectionDate = DateTime.ParseExact("15/04/2021", "dd/MM/yyyy", null),
                    VisaDate = DateTime.ParseExact("06/05/2021", "dd/MM/yyyy", null),
                },
                new CarHistory {
                    ID = 10,
                    CarID = 10,
                    InspectionDate = DateTime.ParseExact("15/05/2021", "dd/MM/yyyy", null),
                    VisaDate = DateTime.ParseExact("06/05/2021", "dd/MM/yyyy", null),
                },
                new CarHistory {
                    ID = 11,
                    CarID = 11,
                    InspectionDate = DateTime.ParseExact("15/05/2021", "dd/MM/yyyy", null),
                    VisaDate = DateTime.ParseExact("06/09/2021", "dd/MM/yyyy", null),
                },
                new CarHistory {
                    ID = 12,
                    CarID = 12,
                    InspectionDate = DateTime.ParseExact("15/05/2021", "dd/MM/yyyy", null),
                    VisaDate = DateTime.ParseExact("06/09/2021", "dd/MM/yyyy", null),
                },
                new CarHistory {
                    ID = 13,
                    CarID = 13,
                    InspectionDate = DateTime.ParseExact("15/06/2021", "dd/MM/yyyy", null),
                    VisaDate = DateTime.ParseExact("06/10/2021", "dd/MM/yyyy", null),
                },
                new CarHistory {
                    ID = 14,
                    CarID = 14,
                    InspectionDate = DateTime.ParseExact("15/06/2021", "dd/MM/yyyy", null),
                    VisaDate = DateTime.ParseExact("06/10/2021", "dd/MM/yyyy", null),
                },
                new CarHistory {
                    ID = 15,
                    CarID = 15,
                    InspectionDate = DateTime.ParseExact("15/06/2021", "dd/MM/yyyy", null),
                    VisaDate = DateTime.ParseExact("06/10/2021", "dd/MM/yyyy", null),
                },
                new CarHistory {
                    ID = 16,
                    CarID = 16,
                    InspectionDate = DateTime.ParseExact("15/07/2021", "dd/MM/yyyy", null),
                    VisaDate = DateTime.ParseExact("06/11/2021", "dd/MM/yyyy", null),
                },
                new CarHistory {
                    ID = 17,
                    CarID = 17,
                    InspectionDate = DateTime.ParseExact("15/07/2021", "dd/MM/yyyy", null),
                    VisaDate = DateTime.ParseExact("06/11/2021", "dd/MM/yyyy", null),
                },
                new CarHistory {
                    ID = 18,
                    CarID = 18,
                    InspectionDate = DateTime.ParseExact("15/07/2021", "dd/MM/yyyy", null),
                    VisaDate = DateTime.ParseExact("06/11/2021", "dd/MM/yyyy", null),
                }
           );
        }
    }
}
