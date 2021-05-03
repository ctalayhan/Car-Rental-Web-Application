using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.MVC.Models.ViewModels {
    public class UserLoginVM {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Role { get; set; }
    }
}
