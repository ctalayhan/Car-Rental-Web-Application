using CarRental.BLL.Abstract;
using CarRental.DAL.Abstract;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Concrete
{
    class FuelTypeManager : IFuelTypeService
    {
        IFuelTypeDal _fuelTypeDal;
        public FuelTypeManager(IFuelTypeDal fuelTypeDal)
        {
            _fuelTypeDal = fuelTypeDal;
        }
        public void Add(FuelType fuelType)
        {
            _fuelTypeDal.Add(fuelType);
        }

        public void Delete(FuelType fuelType)
        {
            _fuelTypeDal.Delete(fuelType);
        }

        public void DeleteById(int FuelTypeID)
        {
            _fuelTypeDal.Delete(_fuelTypeDal.Get(x => x.FuelTypeID == FuelTypeID));
        }

        public List<FuelType> GetAll()
        {
            return _fuelTypeDal.GetAll();        
                
        }

        public FuelType GetById(int FuelTypeID)
        {
            return _fuelTypeDal.Get(x => x.FuelTypeID == FuelTypeID);
        }

        public void Update(FuelType fuelType)
        {
            _fuelTypeDal.Update(fuelType);
        }
    }
}
