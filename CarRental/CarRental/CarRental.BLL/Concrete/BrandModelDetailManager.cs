using CarRental.BLL.Abstract;
using CarRental.DAL.Abstract;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Concrete
{
    public class BrandModelDetailManager : IBrandModelDetailService
    {
        IBrandModelDetailDal _brandModelDetailDal;
        public BrandModelDetailManager(IBrandModelDetailDal brandModelDetailDal)
        {
            _brandModelDetailDal = brandModelDetailDal;
        }
        public void Add(BrandModelDetail brandModelDetail)
        {
            _brandModelDetailDal.Add(brandModelDetail);
        }

        public void Delete(BrandModelDetail brandModelDetail)
        {
            _brandModelDetailDal.Delete(brandModelDetail);
        }

        public void DeleteById(int brandModelDetailID)
        {
            _brandModelDetailDal.Delete(_brandModelDetailDal.Get(x => x.BrandModelDetailID== brandModelDetailID));
        }

        public List<BrandModelDetail> GetAll()
        {
            return _brandModelDetailDal.GetAll();
        }

        public BrandModelDetail GetById(int brandModelDetailID)
        {
            return _brandModelDetailDal.Get(x => x.BrandModelDetailID== brandModelDetailID);
        }

        public void Update(BrandModelDetail brandModelDetail)
        {
            _brandModelDetailDal.Update(brandModelDetail);
        }
    }
}
