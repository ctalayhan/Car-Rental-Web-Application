using CarRental.BLL.Abstract;
using CarRental.DAL.Abstract;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Concrete
{
    public class CarHistoryManager : ICarHistoryService
    {
        ICarHistoryDal _carHistoryDal;
        public CarHistoryManager(ICarHistoryDal carHistoryDal)
        {
            _carHistoryDal = carHistoryDal;
        }
        public void Add(CarHistory carHistory)
        {
            _carHistoryDal.Add(carHistory);
        }

        public void Delete(CarHistory carHistory)
        {
            _carHistoryDal.Delete(carHistory);
        }

        public void DeleteById(int ID)
        {
            _carHistoryDal.Delete(_carHistoryDal.Get(x => x.ID == ID));
        }

        public List<CarHistory> GetAll()
        {
            return _carHistoryDal.GetAll();
        }

        public CarHistory GetById(int ID)
        {
            return _carHistoryDal.Get(x => x.ID == ID);
        }

        public void Update(CarHistory carHistory)
        {
            _carHistoryDal.Update(carHistory);
        }
    }
}
