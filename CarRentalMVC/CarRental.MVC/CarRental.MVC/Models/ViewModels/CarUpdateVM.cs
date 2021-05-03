using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.MVC.Models.ViewModels
{
    public class CarUpdateVM
    {
        public CarUpdateVM()
        {
            GearTypeList = new List<GearVM>();
            FuelTypeList = new List<FuelTypeVM>();
            ModelList = new List<ModelVM>();

        }
        public List<GearVM> GearTypeList { get; set; }
        public List<FuelTypeVM> FuelTypeList { get; set; }
        public List<ModelVM> ModelList { get; set; }

        public int CarID { get; set; }
        public string PlateNo { get; set; }
        public string ChassisNo { get; set; }
        public int GearID { get; set; }
        public int BrandModelDetailID { get; set; }
        public int FuelTypeID { get; set; }
        public decimal DailyFee { get; set; }
    }
}
