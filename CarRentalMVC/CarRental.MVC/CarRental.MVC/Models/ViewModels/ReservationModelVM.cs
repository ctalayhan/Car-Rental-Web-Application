using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.MVC.Models.ViewModels {
    public class ReservationModelVM {

        public int ReservationID { get; set; }
        public string UserName { get; set; }
        public string Status { get; set; }
        public DateTime ReservationDate { get; set; }
        public string EmployeeName { get; set; }
    }
}
