using CarRental.BLL.Abstract;
using CarRental.DAL.Abstract;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Concrete
{
    public class GearManager : IGearService
    {
        IGearDal _gearDal;
        public GearManager(IGearDal gearDal)
        {
            _gearDal = gearDal;
        }

        public void Add(Gear gear)
        {
            _gearDal.Add(gear);
        }

        public void Delete(Gear gear)
        {
            _gearDal.Delete(gear);
        }
        public void DeleteById(int gearID)
        {
                _gearDal.Delete(_gearDal.Get(x => x.GearID == gearID));
            }

        public List<Gear> GetAll()
        {
            return _gearDal.GetAll();
        }

        public Gear GetById(int gearID)
        {
            return _gearDal.Get(x => x.GearID == gearID);
        }

        public void Update(Gear gear)
        {
            _gearDal.Update(gear);
        }
    }
}
