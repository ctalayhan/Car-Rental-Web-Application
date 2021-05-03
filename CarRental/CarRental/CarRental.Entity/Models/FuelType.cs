using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Entity.Models {
    public class FuelType : IEntity
    {
        public FuelType()
        {
            Cars = new HashSet<Car>();
        }

        public int FuelTypeID { get; set; }
        public string FuelTypeName { get; set; }
        public string Description { get; set; }

        //Navigation

        public ICollection<Car> Cars { get; set; }
    }
}
