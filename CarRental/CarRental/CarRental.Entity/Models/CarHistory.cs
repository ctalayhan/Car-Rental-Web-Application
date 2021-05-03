using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Entity.Models {
    public class CarHistory : IEntity
    {
        public int ID { get; set; }
        public int CarID { get; set; }
        public DateTime InspectionDate { get; set; }
        public DateTime VisaDate { get; set; }

        //Navigation

        public Car Car { get; set; }
    }
}
