using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Entity.Models {
    public class Insurance : IEntity
    {
        public Insurance()
        {
            ReservationDetails = new HashSet<ReservationDetail>();
        }

        public int InsuranceID { get; set; }
        public string Description { get; set; }

        //Navigation
        public ICollection<ReservationDetail> ReservationDetails { get; set; }
    }
}
