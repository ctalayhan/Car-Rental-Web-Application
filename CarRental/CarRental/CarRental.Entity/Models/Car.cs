using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Entity.Models {
    public class Car : IEntity
    {
        public Car()
        {
            CarStatus = new HashSet<CarStatus>();
            ReservationDetails = new HashSet<ReservationDetail>();
            CarHistories = new HashSet<CarHistory>();
        }
        public int CarID { get; set; }
        public string PlateNo { get; set; }
        public string ChassisNo { get; set; }
        public int GearID { get; set; }
        public int BrandModelDetailID { get; set; }
        public int FuelTypeID { get; set; }
        public decimal DailyFee { get; set; }

        //Navigation
        public BrandModelDetail BrandModelDetail { get; set; }
        public FuelType FuelType { get; set; }
        public Gear Gear { get; set; }
        public ICollection<CarStatus> CarStatus { get; set; }
        public ICollection<ReservationDetail> ReservationDetails { get; set; }
        public ICollection<CarHistory> CarHistories { get; set; }

    }
}
