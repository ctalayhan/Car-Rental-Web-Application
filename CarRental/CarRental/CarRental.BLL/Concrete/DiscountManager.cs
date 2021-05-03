using CarRental.BLL.Abstract;
using CarRental.DAL.Abstract;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Concrete
{
    public class DiscountManager : IDiscountService
    {
        IDiscountDal _discountDal;
        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }
        public void Add(Discount discount)
        {
            _discountDal.Add(discount);
        }

        public void Delete(Discount discount)
        {
            _discountDal.Delete(discount);
        }

        public void DeleteById(int discountId)
        {
            _discountDal.Delete(_discountDal.Get(x => x.DiscountID == discountId));
        }

        public List<Discount> GetAll()
        {
            return _discountDal.GetAll();
        }

        public Discount GetById(int discountId)
        {
            return _discountDal.Get(x => x.DiscountID == discountId);
        }

        public void Update(Discount discount)
        {
            _discountDal.Update(discount);
        }
    }
}
