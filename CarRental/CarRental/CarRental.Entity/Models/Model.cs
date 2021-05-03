using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Entity.Models {
    public class Model : IEntity
    {
        public int ModelID { get; set; }
        public string ModelName { get; set; }
        public int BrandRefID { get; set; }

        //Navigation
        public CarBrand CarBrand { get; set; }

    }
}
