using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarRental.Entity.Models {
    public class Employee : IEntity
    {
        public Employee()
        {
            Reservations = new HashSet<Reservation>();
            Employees = new HashSet<Employee>();
        }
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char? Gender { get; set; }
        public string BloodType { get; set; }
        public string Email { get; set; }
        public string Education { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int? ReportsToID { get; set; }
        public byte[] Image { get; set; }
        public string Summary { get; set; }

        //Navigation

        public ICollection<Reservation> Reservations { get; set; }

        public Employee ReportsTo { get; set; } // Birdaha bak !!!!
        public ICollection<Employee> Employees { get; set; }
    }
}
