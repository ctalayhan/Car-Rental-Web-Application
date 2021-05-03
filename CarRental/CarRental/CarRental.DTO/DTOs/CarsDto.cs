using CarRental.Core.Entities;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DTO.DTOs
{
    public class CarsDto
    {

        public CarsDto()
        {
            ModelList = new List<string>();

        }
        public int CarID { get; set; }
        public string PlateNo { get; set; }
        public string ChassisNo { get; set; }
        public string GearName { get; set; }
        public string ModelName { get; set; }
        public string FuelType { get; set; }
        public decimal DailyFee { get; set; }

        public List<string> ModelList { get; set; }

        public int GearID { get; set; }
        public int BrandModelDetailID { get; set; }
        public int FuelTypeID { get; set; }

    }
}
