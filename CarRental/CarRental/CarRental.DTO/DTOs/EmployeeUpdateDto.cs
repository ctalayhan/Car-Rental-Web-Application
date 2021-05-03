using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DTO.DTOs
{
    public class EmployeeUpdateDto
    {
        public EmployeeUpdateDto()
        {
            Directors = new List<DirectorsDto>();
        }
        public List<DirectorsDto> Directors { get; set; }
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
