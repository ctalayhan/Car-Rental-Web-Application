using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Abstract
{
    public interface IDriverService
    {
        void Add(Driver driver);
        void Update(Driver driver);
        void Delete(Driver driver);
        void DeleteById(int driverId);
        Driver GetById(int driverId);
        List<Driver> GetAll();
    }
}
