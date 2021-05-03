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
    public class ReservationDetailController : ControllerBase
    {
        IReservationDetailService _reservationDetailService;
        IMapper _mapper;

        public ReservationDetailController(IReservationDetailService reservationDetailService, IMapper mapper)
        {
            _reservationDetailService = reservationDetailService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllReservationDetail()
        {
            var reservationDetail = _reservationDetailService.GetAll();
            return Ok(_mapper.Map<IEnumerable<ReservationDetailsDto>>(reservationDetail));
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdReservationDetail(int id)
        {
            var reservationDetail = _reservationDetailService.GetById(id);
            return Ok(_mapper.Map<IEnumerable<ReservationDetailsDto>>(reservationDetail));
        }



        [HttpPost]
        public IActionResult AddReservationDetail([FromBody] ReservationDetailsDto reservationDetailsDto)
        {
            _reservationDetailService.Add(_mapper.Map<ReservationDetail>(reservationDetailsDto));
            return Created(string.Empty, null);
        }

        [HttpPut]
        public IActionResult UpdateReservationDetail([FromBody] ReservationDetailsDto reservationDetailsDto)
        {
            _reservationDetailService.Update(_mapper.Map<ReservationDetail>(reservationDetailsDto));
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteReservationdetail([FromBody] ReservationDetailsDto reservationDetailsDto)
        {
            _reservationDetailService.Delete(_mapper.Map<ReservationDetail>(reservationDetailsDto));
            return NoContent();
        }

        // DeleteById metodu kullanılamadı compozik key olduğu için
    }
}
