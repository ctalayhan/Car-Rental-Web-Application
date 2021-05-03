using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DTO.DTOs
{
    public class UpdateCarDto
    {
        public UpdateCarDto()
        {
            GearTypeList = new List<GearsDto>();
            FuelTypeList = new List<FuelTypesDto>();
            ModelList = new List<ModelsDto>();

        }
        public List<GearsDto> GearTypeList { get; set; }
        public List<FuelTypesDto> FuelTypeList { get; set; }
        public List<ModelsDto> ModelList { get; set; }

        public int CarID { get; set; }
        public string PlateNo { get; set; }
        public string ChassisNo { get; set; }
        public int GearID { get; set; }
        public int BrandModelDetailID { get; set; }
        public int FuelTypeID { get; set; }
        public decimal DailyFee { get; set; }
    }
}
