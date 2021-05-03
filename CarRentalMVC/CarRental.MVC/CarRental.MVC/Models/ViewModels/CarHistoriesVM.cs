using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.MVC.Models.ViewModels
{
    public class CarHistoriesVM
    {
        public int ID { get; set; }
        public int CarID { get; set; }
        public DateTime InspectionDate { get; set; }
        public DateTime VisaDate { get; set; }
    }
}
