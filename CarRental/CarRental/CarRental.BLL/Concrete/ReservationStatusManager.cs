using CarRental.BLL.Abstract;
using CarRental.DAL.Abstract;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Concrete {
    public class ReservationStatusManager :IReservationStatusService {
        IReservationStatusDal _reservationStatusDal;
        public ReservationStatusManager(IReservationStatusDal reservationStatusDal) {
            _reservationStatusDal = reservationStatusDal;

        }

        public void Add(ReservationStatus reservationStatus) {
            _reservationStatusDal.Add(reservationStatus);
        }

        public void Delete(ReservationStatus reservationStatus) {
            _reservationStatusDal.Delete(reservationStatus);
        }

        public void DeleteById(int reservationStatusId) {
            _reservationStatusDal.Delete(_reservationStatusDal.Get(x => x.ReservationStatusID == reservationStatusId));
        }

        public List<ReservationStatus> GetAll() {
            return _reservationStatusDal.GetAll();
        }

        public ReservationStatus GetById(int reservationStatusId) {
            return _reservationStatusDal.Get(x => x.ReservationStatusID == reservationStatusId);
        }

        public void Update(ReservationStatus reservationStatus) {
            _reservationStatusDal.Update(reservationStatus);
        }
    }
}
