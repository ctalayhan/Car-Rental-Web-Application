using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.MVC.Models.ViewModels
{
    public class CarDetailsVM
    {
        public CarDetailsVM()
        {
            CarHistories = new List<CarHistoriesVM>();
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


        public List<CarHistoriesVM> CarHistories { get; set; }
    }
}
