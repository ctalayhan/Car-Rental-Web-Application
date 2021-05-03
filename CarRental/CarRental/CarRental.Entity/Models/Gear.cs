using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Entity.Models {
    public class Gear : IEntity
    {
        public Gear()
        {
            Cars = new HashSet<Car>();
        }
        public int GearID { get; set; }
        public string GearType { get; set; }

        //Navigation

        public ICollection<Car> Cars { get; set; }

    }
}
