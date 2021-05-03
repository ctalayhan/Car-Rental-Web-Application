using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DTO.DTOs
{
    public class CarHistoriesDto
    {
        public int ID { get; set; }
        public int CarID { get; set; }
        public DateTime InspectionDate { get; set; }
        public DateTime VisaDate { get; set; }
    }
}
