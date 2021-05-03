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
    public class DriverController : ControllerBase
    {
        IDriverService _driverService;
        IMapper _mapper;
        public DriverController(IDriverService driverService, IMapper mapper)
        {
            _mapper = mapper;
            _driverService = driverService;
        }
        [HttpGet]
        public IActionResult GetAllDriver()
        {
            var drivers = _driverService.GetAll();
            return Ok(_mapper.Map<IEnumerable<DriversDto>>(drivers));
        }
        [HttpGet("{id}")]
        public IActionResult GetByIdDriver(int id)
        {
            var driver = _driverService.GetById(id);
            return Ok(_mapper.Map<DriversDto>(driver));
        }
        [HttpPost]
        public IActionResult AddDriver([FromBody] DriversDto driversDto)
        {
            _driverService.Add(_mapper.Map<Driver>(driversDto));
            return Created(string.Empty, null);
        }
        [HttpPut]
        public IActionResult UpdateDriver([FromBody] DriversDto driversDto)
        {
            _driverService.Update(_mapper.Map<Driver>(driversDto));
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteDriver([FromBody] DriversDto driversDto)
        {
            _driverService.Delete(_mapper.Map<Driver>(driversDto));
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteByIdDriver(int id)
        {
            _driverService.DeleteById(id);
            return NoContent();
        }

    }
}
