using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Abstract
{
    public interface ICarStatusTypeService
    {
        void Add(CarStatusType carStatusType);
        void Update(CarStatusType carStatusType);
        void Delete(CarStatusType carStatusType);
        void DeleteById(int StateID);
        CarStatusType GetById(int StateID);
        List<CarStatusType> GetAll();
    }
}
