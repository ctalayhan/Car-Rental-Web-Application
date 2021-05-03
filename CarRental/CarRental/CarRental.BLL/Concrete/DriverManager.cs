using CarRental.BLL.Abstract;
using CarRental.DAL.Abstract;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Concrete
{
    public class DriverManager : IDriverService
    {
        IDriverDal _driverDal;
        public DriverManager(IDriverDal driverDal)
        {
            _driverDal = driverDal;
        }
        public void Add(Driver driver)
        {
            _driverDal.Add(driver);
        }

        public void Delete(Driver driver)
        {
            _driverDal.Delete(driver);
        }

        public void DeleteById(int driverId)
        {
            _driverDal.Delete(_driverDal.Get(x => x.DriverID == driverId));
        }

        public List<Driver> GetAll()
        {
            return _driverDal.GetAll();
        }

        public Driver GetById(int driverId)
        {
            return _driverDal.Get(x => x.DriverID == driverId);
        }

        public void Update(Driver driver)
        {
            _driverDal.Update(driver);
        }
    }
}
