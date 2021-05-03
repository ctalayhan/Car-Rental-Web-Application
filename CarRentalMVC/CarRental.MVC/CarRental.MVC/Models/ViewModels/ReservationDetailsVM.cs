using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.MVC.Models.ViewModels
{
    public class ReservationDetailsVM
    {

        public int ReservationID { get; set; }
        public int CarID { get; set; }
        public string CarName { get; set; }
        public decimal DailyFee { get; set; }
        public int? DayCount { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal DiscountRatio { get; set; }
        public string DeliveryLocation { get; set; }
        public string ReturnLocation { get; set; }

        public string InsuranceDescription { get; set; }

        public string DriverName { get; set; }

        public string ContractType { get; set; }
        public string DeliveryEmployeeName { get; set; }
        public string ReturnEmployeelName { get; set; }


    }
}
