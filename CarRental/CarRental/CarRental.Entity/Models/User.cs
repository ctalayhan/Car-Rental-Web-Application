using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Entity.Models {
    public class User : IEntity
    {
        public User()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Role { get; set; }

        //Navigation

        public ICollection<Reservation> Reservations { get; set; }
    }
}
