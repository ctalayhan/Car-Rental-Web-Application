using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Abstract
{
    public interface IDriverLicenseClassService
    {
        void Add(DriverLicenseClass driverLicenseClass);
        void Update(DriverLicenseClass driverLicenseClass);
        void Delete(DriverLicenseClass driverLicenseClass);
        void DeleteById(int ClassID);
        DriverLicenseClass GetById(int ClassID);
        List<DriverLicenseClass> GetAll();
    }
}
