using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Abstract
{
    public interface IInsuranceService
    {
        void Add(Insurance insurance);
        void Update(Insurance insurance);
        void Delete(Insurance insurance);
        void DeleteById(int insuranceId);
        Insurance GetById(int insuranceId);
        List<Insurance> GetAll();
    }
}

