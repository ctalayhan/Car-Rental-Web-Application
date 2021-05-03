using CarRental.BLL.Abstract;
using CarRental.DAL.Abstract;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Concrete
{
    public class CarBrandManager : ICarBrandService
    {
        ICarBrandDal _carBrandDal;
        public CarBrandManager(ICarBrandDal carBrandDal)
        {
            _carBrandDal = carBrandDal;
        }
        public void Add(CarBrand carBrand)
        {
            _carBrandDal.Add(carBrand);
        }

        public void Delete(CarBrand carBrand)
        {
            _carBrandDal.Delete(carBrand);
        }

        public void DeleteById(int brandID)
        {
            _carBrandDal.Delete(_carBrandDal.Get(x => x.BrandID == brandID));
        }

        public List<CarBrand> GetAll()
        {
           return _carBrandDal.GetAll();
        }

        public CarBrand GetById(int brandID)
        {
            return _carBrandDal.Get(x => x.BrandID == brandID);
        }

        public void Update(CarBrand carBrand)
        {
            _carBrandDal.Update(carBrand);
        }
    }
}
