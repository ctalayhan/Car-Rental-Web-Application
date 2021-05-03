using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Abstract
{
    public interface ICarHistoryService
    {
        void Add(CarHistory carHistory);
        void Update(CarHistory carHistory);
        void Delete(CarHistory carHistory);
        void DeleteById(int ID);
        CarHistory GetById(int ID);
        List<CarHistory> GetAll();
    }
}
