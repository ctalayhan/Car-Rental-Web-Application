using CarRental.BLL.Abstract;
using CarRental.DAL.Abstract;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Concrete
{
    public class InsuranceManager : IInsuranceService
    {
        IInsuranceDal _insuranceDal;
        public InsuranceManager(IInsuranceDal insuranceDal)
        {
            _insuranceDal = insuranceDal;
        }

        public void Add(Insurance insurance)
        {
            _insuranceDal.Add(insurance);
        }

        public void Delete(Insurance insurance)
        {
            _insuranceDal.Delete(insurance);
        }

        public void DeleteById(int insuranceId)
        {
            _insuranceDal.Delete(_insuranceDal.Get(x => x.InsuranceID == insuranceId));
        }

        public List<Insurance> GetAll()
        {
            return _insuranceDal.GetAll();
        }

        public Insurance GetById(int insuranceId)
        {
            return _insuranceDal.Get(x => x.InsuranceID == insuranceId);
        }

        public void Update(Insurance insurance)
        {
            _insuranceDal.Update(insurance);
        }
    }
}
