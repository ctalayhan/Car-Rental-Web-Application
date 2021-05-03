using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Seeding
{
    public static class ReservationDetailSeed
    {
        

        public static void ReservationDetailSeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReservationDetail>().HasData(
                new ReservationDetail
                {
                    ReservationID = 1,
                    CarID = 1,
                    DailyFee = 200.0000m,
                    DayCount = 3,
                    DeliveryDate = DateTime.Now,
                    ReturnDate = null,
                    DiscountID = 1,
                    DeliveryLocation = "Baglarbasi cad Maltepe",
                    ReturnLocation = "Baglarbasi cad Maltepe",
                    InsuranceID = 1,
                    DriverID = 1,
                    ContractID  = 1,
                    DeliveryEmployeeID = 10,
                    ReturnEmployeelID = 14,
                },
                new ReservationDetail
                {
                    ReservationID = 2,
                    CarID = 2,
                    DailyFee = 250.0000m,
                    DayCount = 5,
                    DeliveryDate = DateTime.Now,
                    ReturnDate = null,
                    DiscountID = 1,
                    DeliveryLocation = "Eskisehir cad Kurtulus",
                    ReturnLocation = "Eskisehir cad Kurtulus",
                    InsuranceID = 2,
                    DriverID = 2,
                    ContractID  = 2,
                    DeliveryEmployeeID = 11,
                    ReturnEmployeelID = 12,
                },
                new ReservationDetail
                {
                    ReservationID = 3,
                    CarID = 3,
                    DailyFee = 250.0000m,
                    DayCount = 7,
                    DeliveryDate = DateTime.Now,
                    ReturnDate = null,
                    DiscountID = 2,
                    DeliveryLocation = "Adiyaman cad Bagcilar",
                    ReturnLocation = "Eskisehir cad Kurtulus",
                    InsuranceID = 3,
                    DriverID = 3,
                    ContractID  = 3,
                    DeliveryEmployeeID = 13,
                    ReturnEmployeelID = 11,
                },
                new ReservationDetail
                {
                    ReservationID = 4,
                    CarID = 4,
                    DailyFee = 225.0000m,
                    DayCount = 7,
                    DeliveryDate = DateTime.Now,
                    ReturnDate = null,
                    DiscountID = 2,
                    DeliveryLocation = "Esenler Otogar",
                    ReturnLocation = "Sabiha Gökçen Kurtköy",
                    InsuranceID = 1,
                    DriverID = 4,
                    ContractID  = 4,
                    DeliveryEmployeeID = 12,
                    ReturnEmployeelID = 10,
                },
                new ReservationDetail
                {
                    ReservationID = 5,
                    CarID = 5,
                    DailyFee = 300.0000m,
                    DayCount = 6,
                    DeliveryDate = DateTime.Now,
                    ReturnDate = null,
                    DiscountID = 2,
                    DeliveryLocation = "Atatürk Havalimani",
                    ReturnLocation = "Atatürk Havalimani",
                    InsuranceID = 3,
                    DriverID = 5,
                    ContractID  = 5,
                    DeliveryEmployeeID = 10,
                    ReturnEmployeelID = 11,
                },
                new ReservationDetail
                {
                    ReservationID = 5,
                    CarID = 6,
                    DailyFee = 300.0000m,
                    DayCount = 6,
                    DeliveryDate = DateTime.Now,
                    ReturnDate = null,
                    DiscountID = 2,
                    DeliveryLocation = "Atatürk Havalimani",
                    ReturnLocation = "Atatürk Havalimani",
                    InsuranceID = 3,
                    DriverID = 6,
                    ContractID  = 6,
                    DeliveryEmployeeID = 12,
                    ReturnEmployeelID = 13,
                },
                new ReservationDetail
                {
                    ReservationID = 5,
                    CarID = 7,
                    DailyFee = 300.0000m,
                    DayCount = 6,
                    DeliveryDate = DateTime.Now,
                    ReturnDate = null,
                    DiscountID = 2,
                    DeliveryLocation = "Atatürk Havalimani",
                    ReturnLocation = "Atatürk Havalimani",
                    InsuranceID = 3,
                    DriverID = 7,
                    ContractID  = 7,
                    DeliveryEmployeeID = 14,
                    ReturnEmployeelID = 10,
                },
                new ReservationDetail
                {
                    ReservationID = 6,
                    CarID = 8,
                    DailyFee = 275.0000m,
                    DayCount = 1,
                    DeliveryDate = DateTime.Now,
                    ReturnDate = null,
                    DiscountID = 1,
                    DeliveryLocation = "Gümüssuyu Taksim",
                    ReturnLocation = "Gümüssuyu Taksim",
                    InsuranceID = 1,
                    DriverID = 8,
                    ContractID  = 8,
                    DeliveryEmployeeID = 10,
                    ReturnEmployeelID = 14,
                },
                new ReservationDetail
                {
                    ReservationID = 6,
                    CarID = 9,
                    DailyFee = 275.0000m,
                    DayCount = 1,
                    DeliveryDate = DateTime.Now,
                    ReturnDate = null,
                    DiscountID = 1,
                    DeliveryLocation = "Gümüssuyu Taksim",
                    ReturnLocation = "Gümüssuyu Taksim",
                    InsuranceID = 1,
                    DriverID = 9,
                    ContractID  = 9,
                    DeliveryEmployeeID = 11,
                    ReturnEmployeelID = 12,
                });
        }
    }
}
