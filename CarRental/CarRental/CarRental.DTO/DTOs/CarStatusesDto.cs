using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarRental.DTO.DTOs
{
    public class CarStatusesDto
    {
        public int CarID { get; set; }
        public int StatusID { get; set; }
        [Required]
        public DateTime DateofEntry { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }

    }
}
