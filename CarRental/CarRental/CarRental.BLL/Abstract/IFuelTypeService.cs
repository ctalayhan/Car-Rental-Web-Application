using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Abstract
{
    public interface IFuelTypeService
    {
        void Add(FuelType fuelType);
        void Update(FuelType fuelType);
        void Delete(FuelType fuelType);
        void DeleteById(int FuelTypeID);
        FuelType GetById(int FuelTypeID);
        List<FuelType> GetAll();
    }
}
