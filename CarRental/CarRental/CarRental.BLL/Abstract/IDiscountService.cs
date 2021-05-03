using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Abstract
{
    public interface IDiscountService
    {
        void Add(Discount discount);
        void Update(Discount discount);
        void Delete(Discount discount);
        void DeleteById(int discountId);
        Discount GetById(int discountId);
        List<Discount> GetAll();
    }
}
