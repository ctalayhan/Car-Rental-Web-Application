using CarRental.BLL.Abstract;
using CarRental.DAL.Abstract;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Concrete
{
    class CarStatusTypeManager : ICarStatusTypeService
    {
        ICarStatusTypeDal _carStatusTypeDal;
        public CarStatusTypeManager(ICarStatusTypeDal carStatusTypeDal)
        {
            _carStatusTypeDal = carStatusTypeDal;
        }
        public void Add(CarStatusType carStatusType)
        {
            _carStatusTypeDal.Add(carStatusType);
        }

        public void Delete(CarStatusType carStatusType)
        {
            _carStatusTypeDal.Delete(carStatusType);
        }

        public void DeleteById(int StateID)
        {
            _carStatusTypeDal.Delete(_carStatusTypeDal.Get(x => x.StateID == StateID));
        }

        public List<CarStatusType> GetAll()
        {
            return _carStatusTypeDal.GetAll();
        }

        public CarStatusType GetById(int StateID)
        {
            return _carStatusTypeDal.Get(x => x.StateID == StateID);
        }

        public void Update(CarStatusType carStatusType)
        {
            _carStatusTypeDal.Update(carStatusType);
        }
    }
}
