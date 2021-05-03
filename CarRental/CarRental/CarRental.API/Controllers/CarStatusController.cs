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
    public class CarStatusController : ControllerBase
    {
        ICarStatusService _carStatusService;
        IMapper _mapper;

        public CarStatusController(ICarStatusService carStatusService, IMapper mapper)
        {
            _carStatusService = carStatusService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllCarStatuses()
        {
            var carStatuses = _carStatusService.GetAll();
            if (carStatuses != null || (!carStatuses.Any()))
            {
                return Ok(_mapper.Map<IEnumerable<CarStatusesDto>>(carStatuses));
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdCarStatuses(int id)
        {
            var carStatuses = _carStatusService.GetById(id);

            return Ok(_mapper.Map<CarStatusesDto>(carStatuses));

        }

        [HttpPost]
        public IActionResult AddCarStatus([FromBody] CarStatusesDto carStatuses)
        {
            _carStatusService.Add(_mapper.Map<CarStatus>(carStatuses));
            return Created(string.Empty, null);
        }

        [HttpPut]
        public IActionResult UpdateCarStatus([FromBody] CarStatusesDto carStatuses)
        {
            _carStatusService.Update(_mapper.Map<CarStatus>(carStatuses));
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteCarStatus([FromBody] CarStatusesDto carStatuses)
        {
            _carStatusService.Delete(_mapper.Map<CarStatus>(carStatuses));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCarStatusById(int carStatusId)
        {
            _carStatusService.DeleteById(carStatusId);
            return NoContent();
        }
    }
}
