using AutoMapper;
using CarRental.BLL.Abstract;
using CarRental.DTO.DTOs;
using CarRental.Entity.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarHistoryController : ControllerBase
    {
        IMapper _mapper;
        ICarHistoryService _carHistoryService;

        public CarHistoryController(IMapper mapper, ICarHistoryService carHistoryService)
        {
            _carHistoryService = carHistoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllCarHistories()
        {
            var carHistories = _carHistoryService.GetAll();
            if (carHistories != null || (!carHistories.Any()))
            {
                return Ok(_mapper.Map<IEnumerable<CarHistoriesDto>>(carHistories));
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdCarHistories(int id)
        {
            var carHistories = _carHistoryService.GetById(id);


            return Ok(_mapper.Map<CarHistoriesDto>(carHistories));

        }

        [HttpPost]
        public IActionResult AddCarHistory([FromBody] CarHistoriesDto carHistories)
        {
            _carHistoryService.Add(_mapper.Map<CarHistory>(carHistories));
            return Created(string.Empty, null);
        }

        [HttpPut]
        public IActionResult UpdateCarHistory([FromBody] CarHistoriesDto carHistories)
        {
            _carHistoryService.Update(_mapper.Map<CarHistory>(carHistories));
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteCarHistory([FromBody] CarHistoriesDto carHistories)
        {
            _carHistoryService.Delete(_mapper.Map<CarHistory>(carHistories));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCarHistoryById(int carHistoryId)
        {
            _carHistoryService.DeleteById(carHistoryId);
            return NoContent();
        }
    }

}
