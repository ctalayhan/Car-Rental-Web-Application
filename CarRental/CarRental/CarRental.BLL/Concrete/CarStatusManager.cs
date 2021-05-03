using CarRental.BLL.Abstract;
using CarRental.DAL.Abstract;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Concrete
{
    class CarStatusManager : ICarStatusService
    {
        ICarStatusDal _carStatusDal;
        public CarStatusManager(ICarStatusDal carStatusDal)
        {
            _carStatusDal = carStatusDal;
        }
        public void Add(CarStatus carStatus)
        {
            _carStatusDal.Add(carStatus);
        }

        public void Delete(CarStatus carStatus)
        {
            _carStatusDal.Delete(carStatus);
        }

        public void DeleteById(int StatusID)
        {
            _carStatusDal.Delete(_carStatusDal.Get(p=>p.StatusID == StatusID));
        }

        public List<CarStatus> GetAll()
        {
            return _carStatusDal.GetAll();
        }

        public CarStatus GetById(int StatusID)
        {
            return _carStatusDal.Get(p => p.StatusID == StatusID);
        }

        public void Update(CarStatus carStatus)
        {
            _carStatusDal.Update(carStatus);
        }
    }
}
