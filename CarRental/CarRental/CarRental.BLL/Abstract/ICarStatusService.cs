using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Abstract
{
    public interface ICarStatusService
    {
        void Add(CarStatus carStatus);
        void Update(CarStatus carStatus);
        void Delete(CarStatus carStatus);
        void DeleteById(int StatusID);
        CarStatus GetById(int StatusID);
        List<CarStatus> GetAll();
    }
}
