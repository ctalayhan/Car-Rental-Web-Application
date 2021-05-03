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
    public class FuelTypeController : ControllerBase
    {
        IFuelTypeService _fuelTypeService;
        IMapper _mapper;
        public FuelTypeController(IFuelTypeService fuelTypeService, IMapper mapper)
        {
            _mapper = mapper;
            _fuelTypeService = fuelTypeService;
        }

        [HttpGet]
        public IActionResult GetAllFuelType()
        {
            var fuelTypes = _fuelTypeService.GetAll();
            return Ok(_mapper.Map<IEnumerable<FuelTypesDto>>(fuelTypes));
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdFuelType(int id)
        {
            var fuelType = _fuelTypeService.GetById(id);
            return Ok(_mapper.Map<FuelTypesDto>(fuelType));
        }

        [HttpPost]
        public IActionResult AddFuelType([FromBody] FuelTypesDto fuelTypesDto)
        {
            _fuelTypeService.Add(_mapper.Map<FuelType>(fuelTypesDto));
            return Created(string.Empty, null);
        }

        [HttpPut]
        public IActionResult UpdateFuelType([FromBody] FuelTypesDto fuelTypesDto)
        {
            _fuelTypeService.Update(_mapper.Map<FuelType>(fuelTypesDto));
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteFuelType([FromBody] FuelTypesDto fuelTypesDto)
        {
            _fuelTypeService.Delete(_mapper.Map<FuelType>(fuelTypesDto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteByIdFuelType(int id)
        {
            _fuelTypeService.DeleteById(id);
            return NoContent();
        }
    }
}
