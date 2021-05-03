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
    public class ReservationStatusController : ControllerBase
    {
        IReservationStatusService _reservationStatusService;
        IMapper _mapper;
        public ReservationStatusController(IReservationStatusService reservationStatusService, IMapper mapper)
        {
            _reservationStatusService = reservationStatusService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllReservationStatus()
        {
            var reservationStatus = _reservationStatusService.GetAll();
            return Ok(_mapper.Map<IEnumerable<ReservationStatusesDto>>(reservationStatus));
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdReservationStatus(int id)
        {
            var reservationStatus = _reservationStatusService.GetById(id);
            return Ok(_mapper.Map<ReservationStatusesDto>(reservationStatus));
        }

        [HttpPost]
        public IActionResult AddReservationStatus([FromBody] ReservationStatusesDto reservationStatusesDto)
        {
            _reservationStatusService.Add(_mapper.Map<ReservationStatus>(reservationStatusesDto));
            return Created(string.Empty, null);
        }

        [HttpPut]
        public IActionResult UpdateReservationStatus([FromBody] ReservationStatusesDto reservationStatusesDto)
        {
            _reservationStatusService.Update(_mapper.Map<ReservationStatus>(reservationStatusesDto));
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteReservationStatus([FromBody] ReservationStatusesDto reservationStatusesDto)
        {
            _reservationStatusService.Delete(_mapper.Map<ReservationStatus>(reservationStatusesDto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteByIdReservationstatus(int id)
        {
            _reservationStatusService.DeleteById(id);
            return NoContent();
        }
    }
}
