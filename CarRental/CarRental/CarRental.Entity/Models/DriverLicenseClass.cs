using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Entity.Models {
    public class DriverLicenseClass : IEntity
    {
        public DriverLicenseClass()
        {
            Drivers = new HashSet<Driver>();
        }

        public int ClassID { get; set; }
        public string ClassExplanation { get; set; }

        //Navigation

        public ICollection<Driver> Drivers { get; set; }
    }
}
