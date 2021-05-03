using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DTO.DTOs
{
    public class UsersDto
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Role { get; set; }

    }
}
