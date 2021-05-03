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
    public class GearController : ControllerBase
    {
        IGearService _gearService;
        IMapper _mapper;
        public GearController(IGearService gearService, IMapper mapper)
        {
            _gearService = gearService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAllGear()
        {
            var gears = _gearService.GetAll();
            return Ok(_mapper.Map<IEnumerable<GearsDto>>(gears));
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdGear(int id)
        {
            var gear = _gearService.GetById(id);
            return Ok(_mapper.Map<GearsDto>(gear));
        }



        [HttpPost]
        public IActionResult AddGear([FromBody] GearsDto gearsDto)
        {
            _gearService.Add(_mapper.Map<Gear>(gearsDto));
            return Created(string.Empty, null);
        }

        [HttpPut]
        public IActionResult UpdateGear([FromBody] GearsDto gearsDto)
        {
            _gearService.Update(_mapper.Map<Gear>(gearsDto));
            return NoContent();
        }
        [HttpDelete]
        public IActionResult DeleteGear([FromBody] GearsDto gearsDto)
        {
            _gearService.Delete(_mapper.Map<Gear>(gearsDto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteByIdGear(int id)
        {
            _gearService.DeleteById(id);
            return NoContent();
        }

    }
}
