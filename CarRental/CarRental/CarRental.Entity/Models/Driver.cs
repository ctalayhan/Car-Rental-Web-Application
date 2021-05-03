using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Entity.Models {
    public class Driver : IEntity
    {
        public Driver()
        {
            ReservationDetails = new HashSet<ReservationDetail>();
        }

        public int DriverID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int ClassID { get; set; }
        public string TCKNO { get; set; }
        public bool Approval { get; set; }

        //Navigation

        public ICollection<ReservationDetail> ReservationDetails { get; set; }

        public DriverLicenseClass DriverLicenseClass { get; set; }


    }
}
