using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Entity.Models {
    public class Discount : IEntity
    {
        public Discount()
        {
            ReservationDetails = new HashSet<ReservationDetail>();
        }

        public int DiscountID { get; set; }
        public decimal DiscountRatio { get; set; } // Seed metodu yazılırkewn rakamların sonuna "m" koy

        //Navigation
        public ICollection<ReservationDetail> ReservationDetails { get; set; }
    }
}
