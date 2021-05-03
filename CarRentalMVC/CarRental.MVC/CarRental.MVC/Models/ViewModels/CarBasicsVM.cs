using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.MVC.Models.ViewModels
{
    public class CarBasicsVM
    {
        public int CarID { get; set; }
        public string BrandName { get; set; }
        public DateTime ModelYear { get; set; }
        public string ModelName { get; set; }
        public string StatusName { get; set; }

        
    }
}
