using CarRental.DTO.DTOs;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Abstract {
    public interface IReservationService {
        void Add(Reservation reservation);
        void Update(Reservation reservation);
        void Delete(Reservation reservation);
        void DeleteById(int reservationId);
        Reservation GetById(int reservationId);
        //List<Reservation> GetAll();
        public List<ReservationsDto> GetAll();
    }
}
