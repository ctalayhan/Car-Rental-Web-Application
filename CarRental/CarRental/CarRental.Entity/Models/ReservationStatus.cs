using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Entity.Models {
    public class ReservationStatus : IEntity
    {
        public ReservationStatus()
        {
            Reservations = new HashSet<Reservation>();
        }
        public int ReservationStatusID { get; set; }
        public string Description { get; set; }

        //Navigation
        public ICollection<Reservation> Reservations { get; set; }
    }
}
