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
    public class CarStatusTypeController : ControllerBase
    {
        ICarStatusTypeService _carStatusTypeService;
        IMapper _mapper;

        public CarStatusTypeController(ICarStatusTypeService carStatusTypeService,
        IMapper mapper)
        {
            _carStatusTypeService = carStatusTypeService;
            _mapper = mapper;

        }

        [HttpGet]
        public IActionResult GetAllCarStatusTypes()
        {
            var carStatusTypes = _carStatusTypeService.GetAll();
            if (carStatusTypes != null || (!carStatusTypes.Any()))
            {
                return Ok(_mapper.Map<IEnumerable<CarStatusTypeDto>>(carStatusTypes));
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdCarStatusTypes(int id)
        {
            var carStatusTypes = _carStatusTypeService.GetById(id);

            return Ok(_mapper.Map<CarStatusTypeDto>(carStatusTypes));

        }

        [HttpPost]
        public IActionResult AddCarStatusType([FromBody] CarStatusTypeDto carStatusTypes)
        {
            _carStatusTypeService.Add(_mapper.Map<CarStatusType>(carStatusTypes));
            return Created(string.Empty, null);
        }

        [HttpPut]
        public IActionResult UpdateCarStatusType([FromBody] CarStatusTypeDto carStatusTypes)
        {
            _carStatusTypeService.Update(_mapper.Map<CarStatusType>(carStatusTypes));
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteCarStatusType([FromBody] CarStatusTypeDto carStatusTypes)
        {
            _carStatusTypeService.Delete(_mapper.Map<CarStatusType>(carStatusTypes));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCarStatusTypeById(int carStatusTypeId)
        {
            _carStatusTypeService.DeleteById(carStatusTypeId);
            return NoContent();
        }


    }
}
