using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DTO.DTOs
{
    public class ReservationsDto
    {
        public int ReservationID { get; set; }
        public string UserName { get; set; }
        public string Status { get; set; }
        public DateTime ReservationDate { get; set; }
        public string EmployeeName { get; set; }


    }
}
