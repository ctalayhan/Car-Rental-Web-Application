using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Abstract
{
    public interface IGearService
    {
        void Add(Gear gear);
        void Update(Gear gear);
        void Delete(Gear gear);
        void DeleteById(int gearID);
        Gear GetById(int gearID);
        List<Gear> GetAll();
    }
}
