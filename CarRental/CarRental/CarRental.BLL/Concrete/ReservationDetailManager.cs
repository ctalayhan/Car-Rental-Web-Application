using CarRental.BLL.Abstract;
using CarRental.DAL.Abstract;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Concrete
{
    public class ReservationDetailManager : IReservationDetailService
    {
        IReservationDetailDal _reservationDetailDal;
        public ReservationDetailManager(IReservationDetailDal reservationDetailDal)
        {
            _reservationDetailDal= reservationDetailDal;
        }
        public void Add(ReservationDetail reservationDetail)
        {
            _reservationDetailDal.Add(reservationDetail);
        }

        public void Delete(ReservationDetail reservationDetail)
        {
            _reservationDetailDal.Delete(reservationDetail);
        }

        public List<ReservationDetail> GetAll()
        {
            return _reservationDetailDal.GetAll();
        }

        public List<ReservationDetail> GetById(int reservationId)
        {
            return _reservationDetailDal.GetAll(x => x.ReservationID == reservationId);
        }

        public void Update(ReservationDetail reservationDetail)
        {
            throw new NotImplementedException();
        }
    }
}
