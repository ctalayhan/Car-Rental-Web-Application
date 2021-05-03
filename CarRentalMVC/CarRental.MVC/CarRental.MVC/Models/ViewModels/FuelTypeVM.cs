using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.MVC.Models.ViewModels
{
    public class FuelTypeVM
    {
        public int FuelTypeID { get; set; }
        public string FuelTypeName { get; set; }
        public string Description { get; set; }
    }
}
