using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DTO.DTOs
{
    public class CarDetailsDto
    {
        public CarDetailsDto()
        {
            CarHistories = new List<CarHistoriesDto>();
        }
        public int CarID { get; set; }
        public string BrandName { get; set; }
        public string ChassisNo { get; set; }
        public DateTime ModelYear { get; set; }
        public string ModelName { get; set; }
        public string StatusName { get; set; }
        public string GearType { get; set; }
        public string PlateNo { get; set; }
        public string FuelType { get; set; }
        public byte[] Image { get; set; }
        public decimal DailyFee { get; set; }


        public List<CarHistoriesDto> CarHistories { get; set; }

    }
}
