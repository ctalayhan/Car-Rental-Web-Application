using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Entity.Models {
    public class Contract : IEntity
    {
        public Contract()
        {
            ReservationDetails = new HashSet<ReservationDetail>();
        }

        public int ContractID { get; set; }
        public string ContractType { get; set; }

        //Navigation

        public ICollection<ReservationDetail> ReservationDetails { get; set; }
    }
}