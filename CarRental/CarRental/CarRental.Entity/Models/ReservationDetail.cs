using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarRental.Entity.Models {
    public class ReservationDetail : IEntity
    {
        public int ReservationID { get; set; }
        public int CarID { get; set; }
        public decimal DailyFee { get; set; }
        public int? DayCount { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int DiscountID { get; set; }
        public string DeliveryLocation { get; set; }
        public string ReturnLocation { get; set; }      
        public int InsuranceID { get; set; }      
        public int DriverID { get; set; }      
        public int ContractID { get; set; } 
        public int? DeliveryEmployeeID { get; set; } // Değerler manuel olarak  atanacak isme göre ID ataması yapılacak
        public int? ReturnEmployeelID { get; set; } // Değerler manuel olarak  atanacak isme göre ID ataması yapılacak

        //Navigation

        public Reservation Reservation { get; set; }
        public Car Car { get; set; }
        public Discount Discount { get; set; }
        public Insurance Insurance { get; set; }
        public Driver Driver { get; set; }
        public Contract Contract { get; set; }
    }
}
