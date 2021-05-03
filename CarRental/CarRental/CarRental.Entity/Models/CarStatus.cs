using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Entity.Models {
    public class CarStatus : IEntity
    {
        public int CarID { get; set; }
        public int StatusID { get; set; }
        public DateTime DateofEntry { get; set; }
        public DateTime ReleaseDate { get; set; }

        //Navigation

        public Car Car { get; set; }
        public CarStatusType CarStatusType { get; set; }

    }
}
