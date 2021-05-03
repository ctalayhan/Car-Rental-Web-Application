using CarRental.BLL.Abstract;
using CarRental.DAL.Abstract;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Concrete
{
    class DriverLicenseClassManager : IDriverLicenseClassService
    {
        IDriverLicenseClassDal _driverLicenseClassDal;
        public DriverLicenseClassManager(IDriverLicenseClassDal driverLicenseClassDal)
        {
            _driverLicenseClassDal = driverLicenseClassDal;
        }

        public void Add(DriverLicenseClass driverLicenseClass)
        {
            _driverLicenseClassDal.Add(driverLicenseClass);
        }

        public void Delete(DriverLicenseClass driverLicenseClass)
        {
            _driverLicenseClassDal.Delete(driverLicenseClass);
        }

        public void DeleteById(int ClassID)
        {
            _driverLicenseClassDal.Delete(_driverLicenseClassDal.Get(p => p.ClassID == ClassID));
        }

        public List<DriverLicenseClass> GetAll()
        {
            return _driverLicenseClassDal.GetAll();
        }

        public DriverLicenseClass GetById(int ClassID)
        {
            return _driverLicenseClassDal.Get(p => p.ClassID == ClassID);
        }

        public void Update(DriverLicenseClass driverLicenseClass)
        {
            _driverLicenseClassDal.Update(driverLicenseClass);
        }
    }
}
