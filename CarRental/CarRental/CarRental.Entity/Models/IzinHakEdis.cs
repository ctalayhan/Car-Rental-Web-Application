using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Entity.Models {
    public class IzinHakEdis
    {

        public int KayitID { get; set; }
        public int PersonelID { get; set; }
        public DateTime GecerlilikTarihi { get; set; }
        public int GunSayisi { get; set; }
    }
}
