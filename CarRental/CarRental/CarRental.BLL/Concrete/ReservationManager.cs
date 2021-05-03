using CarRental.BLL.Abstract;
using CarRental.DAL.Abstract;
using CarRental.DTO.DTOs;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Concrete {
    public class ReservationManager :IReservationService {
        IReservationDal _reservationDal;
        public ReservationManager(IReservationDal reservationDal) {
            _reservationDal = reservationDal;
        }

        public void Add(Reservation reservation) {
            _reservationDal.Add(reservation);
        }

        public void Delete(Reservation reservation) {
            _reservationDal.Delete(reservation);
        }

        public void DeleteById(int reservationId) {
            _reservationDal.Delete(_reservationDal.Get(x => x.ReservationID == reservationId));

        }

        public List<ReservationsDto> GetAll() {
            var result = _reservationDal.GetAll(null, x => x.ReservationDetails,x=>x.ReservationStatus, x=>x.User,x=>x.Employee);

            List<ReservationsDto> reservationsDtos = new List<ReservationsDto>();

            foreach (var item in result) {
                reservationsDtos.Add(new ReservationsDto() {
                    ReservationID = item.ReservationID,
                    UserName=item.User.FirstName + " " + item.User.LastName,
                    Status=item.ReservationStatus.Description,
                    ReservationDate=item.ReservationDate,
                    EmployeeName=item.Employee.FirstName+ " " + item.Employee.LastName,
                });
            }
            return reservationsDtos;
        }

        public Reservation GetById(int reservationId) {
            return _reservationDal.Get(x => x.ReservationID == reservationId);
        }

        public void Update(Reservation reservation) {
            _reservationDal.Update(reservation);
        }
    }
}
