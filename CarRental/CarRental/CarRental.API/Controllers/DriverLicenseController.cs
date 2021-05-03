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
    public class DriverLicenseController : ControllerBase
    {
        IMapper _mapper;
        IDriverLicenseClassService _driverLicenseClassService;

        public DriverLicenseController(IMapper mapper,
        IDriverLicenseClassService driverLicenseClassService)
        {
            _driverLicenseClassService = driverLicenseClassService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllDriverLicenseClasses()
        {
            var driverLicenseClasses = _driverLicenseClassService.GetAll();
            if (driverLicenseClasses != null || (!driverLicenseClasses.Any()))
            {
                return Ok(_mapper.Map<IEnumerable<DriverLicensesDto>>(driverLicenseClasses));
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdDriverLicenseClasses(int id)
        {
            var driverLicenseClasses = _driverLicenseClassService.GetById(id);

            return Ok(_mapper.Map<DriverLicensesDto>(driverLicenseClasses));

        }

        [HttpPost]
        public IActionResult AddDriverLicenseClass([FromBody] DriverLicensesDto driverLicenseClasses)
        {
            _driverLicenseClassService.Add(_mapper.Map<DriverLicenseClass>(driverLicenseClasses));
            return Created(string.Empty, null);
        }

        [HttpPut]
        public IActionResult UpdateDriverLicenseClass([FromBody] DriverLicensesDto driverLicenseClasses)
        {
            _driverLicenseClassService.Update(_mapper.Map<DriverLicenseClass>(driverLicenseClasses));
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteDriverLicenseClass([FromBody] DriverLicensesDto driverLicenseClasses)
        {
            _driverLicenseClassService.Delete(_mapper.Map<DriverLicenseClass>(driverLicenseClasses));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDriverLicenseClassById(int driverLicenseClassId)
        {
            _driverLicenseClassService.DeleteById(driverLicenseClassId);
            return NoContent();
        }
    }
}
