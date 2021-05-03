using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarRental.DTO.DTOs
{
    public class FuelTypesDto
    {
        public int FuelTypeID { get; set; }        
        public string FuelTypeName { get; set; }
        public string Description { get; set; }

    }
}
