using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DTO.DTOs
{
    public class ReservationDetailsDto
    {
        public int ReservationID { get; set; }
        public int CarID { get; set; }
        public decimal DailyFee { get; set; }
        public int? DayCount { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int DiscountID { get; set; }
        public string DeliveryLocation { get; set; }
        public string ReturnLocation { get; set; }

        public int InsuranceID { get; set; }

        public int DriverID { get; set; }

        public int ContractID { get; set; }
        public int? DeliveryEmployeeID { get; set; }
        public int? ReturnEmployeelID { get; set; }

    }
}
