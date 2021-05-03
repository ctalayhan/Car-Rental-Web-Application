using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Abstract {
    public interface IReservationStatusService {
        void Add(ReservationStatus reservationStatus);
        void Update(ReservationStatus reservationStatus);
        void Delete(ReservationStatus reservationStatus);
        void DeleteById(int reservationStatusId);
        ReservationStatus GetById(int reservationStatusId);
        List<ReservationStatus> GetAll();
    }
}
