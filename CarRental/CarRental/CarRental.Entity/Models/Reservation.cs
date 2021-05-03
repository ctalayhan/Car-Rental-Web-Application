using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Entity.Models {
    public class Reservation : IEntity
    {
        public Reservation()
        {
            ReservationDetails = new HashSet<ReservationDetail>();
        }

        public int ReservationID { get; set; }
        public int UserID { get; set; }
        public int StatusID { get; set; }
        public DateTime ReservationDate { get; set; }
        public int EmployeeID { get; set; }

        // Navigation

        public User User { get; set; }
        public ReservationStatus ReservationStatus { get; set; }
        public Employee Employee { get; set; }
        public ICollection<ReservationDetail> ReservationDetails { get; set; }
    }
}
