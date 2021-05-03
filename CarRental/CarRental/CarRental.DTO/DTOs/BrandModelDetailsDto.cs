using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DTO.DTOs
{
    public class BrandModelDetailsDto
    {
        public int BrandModelDetailID { get; set; }
        public int BrandID { get; set; }
        public DateTime ModelYear { get; set; }
        public byte[] Image { get; set; }
    }
}
