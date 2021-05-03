using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.MVC.Models.ViewModels
{
    public class ReservationDetailsUpdateVM
    {

        public ReservationDetailsUpdateVM()
        {
            CarName = new List<ModelsVM>();
            DiscountRatio = new List<DiscountsVM>();
            InsuranceDescription = new List<InsurancesVM>();
            DriverName = new List<DriversVM>();
            ContractType = new List<ContractsVM>();
            DeliveryEmployeeName = new List<EmployeeVM>();
            ReturnEmployeelName = new List<EmployeeVM>();
        }

        public int ReservationID { get; set; }
        public int CarID { get; set; }
        public List<ModelsVM> CarName { get; set; }
        public decimal DailyFee { get; set; }
        public int? DayCount { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public List<DiscountsVM> DiscountRatio { get; set; }
        public string DeliveryLocation { get; set; }
        public string ReturnLocation { get; set; }

        public List<InsurancesVM> InsuranceDescription { get; set; }

        public List<DriversVM> DriverName { get; set; }

        public List<ContractsVM> ContractType { get; set; }
        public List<EmployeeVM> DeliveryEmployeeName { get; set; }
        public List<EmployeeVM> ReturnEmployeelName { get; set; }

    }
}
