using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DTO.DTOs
{
    public class CarsBasicDto
    {
        public int CarID { get; set; }
        public string BrandName { get; set; }
        public DateTime ModelYear { get; set; }
        public string ModelName { get; set; }
        public string StatusName { get; set; }
       
    }
}
