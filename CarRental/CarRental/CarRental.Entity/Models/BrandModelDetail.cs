using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarRental.Entity.Models {
    public class BrandModelDetail : IEntity
    {
        public BrandModelDetail() {
            Cars = new HashSet<Car>();
        }

        public int BrandModelDetailID { get; set; }
        public int BrandRefID { get; set; }
        public DateTime ModelYear { get; set; }
        public byte[] Image { get; set; }

        //Navigation

        public CarBrand CarBrand { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
