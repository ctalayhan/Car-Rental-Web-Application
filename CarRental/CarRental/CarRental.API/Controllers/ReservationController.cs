using AutoMapper;
using CarRental.BLL.Abstract;
using CarRental.DTO.DTOs;
using CarRental.Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        IReservationService _reservationService;
        IMapper _mapper;
        public ReservationController(IReservationService reservationService, IMapper mapper)
        {
            _mapper = mapper;
            _reservationService = reservationService;

        }

        [HttpGet]
        public IActionResult GetAllReservation()
        {
            var reservation = _reservationService.GetAll();
            return Ok(_mapper.Map<IEnumerable<ReservationsDto>>(reservation));
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdReservation(int id)
        {
            var reservation = _reservationService.GetById(id);
            return Ok(_mapper.Map<ReservationsDto>(reservation));
        }

        [HttpPost]
        public IActionResult AddReservation([FromBody] ReservationsDto reservationsDto)
        {
            _reservationService.Add(_mapper.Map<Reservation>(reservationsDto));
            return Created(string.Empty, null);
        }
        [HttpPut]
        public IActionResult UpdateReservation([FromBody] ReservationsDto reservationsDto)
        {
            _reservationService.Update(_mapper.Map<Reservation>(reservationsDto));
            return NoContent();
        }
        [HttpDelete]
        public IActionResult DeleteReservation([FromBody] ReservationsDto reservationsDto)
        {
            _reservationService.Delete(_mapper.Map<Reservation>(reservationsDto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteByIdReservation(int id)
        {
            _reservationService.DeleteById(id);
            return NoContent();
        }

    }
}
