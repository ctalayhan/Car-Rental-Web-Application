using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Entity.Models {
    public class Izinler
    {
        public int KayitID { get; set; }
        public int IzinTuru { get; set; }
        public int PersonelID { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public int IzinGunSayisi { get; set; }
    }
}
