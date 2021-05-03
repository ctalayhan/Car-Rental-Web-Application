using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Entity.Models {
    public class CarBrand : IEntity
    {
        public CarBrand()
        {
            Models = new HashSet<Model>();
            BrandModelDetails = new HashSet<BrandModelDetail>();
        }

        public int BrandID { get; set; }
        public string BrandName { get; set; }

        //Navigation

        public ICollection<Model> Models { get; set; }
        public ICollection<BrandModelDetail> BrandModelDetails { get; set; }
    }
}
