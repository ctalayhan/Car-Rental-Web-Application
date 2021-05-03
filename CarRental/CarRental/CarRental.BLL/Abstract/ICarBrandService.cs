using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Abstract
{
    public interface ICarBrandService
    {
        void Add(CarBrand carBrand);
        void Update(CarBrand carBrand);
        void Delete(CarBrand carBrand);
        void DeleteById(int brandID);
        CarBrand GetById(int brandID);
        List<CarBrand> GetAll();
    }
}
