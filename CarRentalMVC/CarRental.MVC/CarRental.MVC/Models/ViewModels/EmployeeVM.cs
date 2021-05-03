using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.MVC.Models.ViewModels
{
    public class EmployeeVM
    {
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
    }
}
