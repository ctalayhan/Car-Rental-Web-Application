using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Abstract
{
    public interface IReservationDetailService
    {
        void Add(ReservationDetail reservationDetail);
        void Update(ReservationDetail reservationDetail);
        void Delete(ReservationDetail reservationDetail);
        List<ReservationDetail> GetAll();


        //void DeleteById(int ReservationDetailId);
        List<ReservationDetail> GetById(int reservationId);
    }
}
