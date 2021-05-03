using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Entity.Models {
    public class CarStatusType : IEntity
    {
        public CarStatusType()
        {
            CarStatus = new HashSet<CarStatus>();
        }

        public int StateID { get; set; }
        public string StatusDescription { get; set; }

        //Navigation
        public ICollection<CarStatus> CarStatus { get; set; }
    }
}
