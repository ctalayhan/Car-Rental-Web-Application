using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Abstract
{
    public interface IBrandModelDetailService
    {
        void Add(BrandModelDetail brandModelDetail);
        void Update(BrandModelDetail brandModelDetail);
        void Delete(BrandModelDetail brandModelDetail);
        void DeleteById(int brandModelDetailID);
        BrandModelDetail GetById(int brandModelDetailID);
        List<BrandModelDetail> GetAll();
    }
}
