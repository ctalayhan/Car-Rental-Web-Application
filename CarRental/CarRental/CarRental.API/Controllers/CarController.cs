using AutoMapper;
using CarRental.BLL.Abstract;
using CarRental.DTO;
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

    public class CarController : ControllerBase
    {
        ICarService _carService;
        IMapper _mapper;
        public CarController(ICarService carService, IMapper mapper)
        {
            _carService = carService;
            _mapper = mapper;
        }

        [Route("[action]")]
        [HttpGet]
        public IActionResult GetCarBasics()
        {
            var cars = _carService.GetCarBasics();           
            if (cars != null || (!cars.Any()))
            {
                return Ok(_mapper.Map<IEnumerable<CarsBasicDto>>(cars));
            }
            else
            {
                return NoContent();
            }
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public IActionResult GetCarDetails(int id)
        {
            var car = _carService.GetCarDetails(id);
            return Ok(car);
        }

        [Route("[action]/{id}")]
        [HttpGet()]
        public IActionResult GetUpdateCarFormInfos(int id)
        {
            var cars = _carService.GetUpdateCarFormInfos(id);
            return Ok(cars);
        }

        [Route("[action]")]
        [HttpGet]
        public IActionResult GetAddedCarFormInfos()
        {
            var cars = _carService.GetAddedCarFormInfos();
            return Ok(cars);


            //var formInfos = _carService.GetAddedCarFormInfos();
            //if (formInfos!=null)
            //{
            //    return Ok(_mapper.Map<AddedCarFormDto>(formInfos));
            //}
            //else
            //{
            //    return NoContent();
            //}
        }

        [Route("[action]")]
        [HttpGet]
        public IActionResult GetAllCars()
        {
            var cars = _carService.GetAll();
            if (cars != null || (!cars.Any()))
            {
                return Ok(_mapper.Map<IEnumerable<CarsDto>>(cars));
            }
            else
            {
                return NoContent();
            }
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public IActionResult GetByIdCars(int id)
        {
            var cars = _carService.GetById(id);

            return Ok(_mapper.Map<CarsDto>(cars));

        }

        [HttpPost]
        public IActionResult AddCar([FromBody] CarsDto cars)
        {
            _carService.Add(_mapper.Map<Car>(cars));
            return Created(string.Empty, null);
        }


        [HttpDelete]
        public IActionResult DeleteCar([FromBody] CarsDto cars)
        {
            _carService.Delete(_mapper.Map<Car>(cars));
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateCar([FromBody] CarsDto cars)
        {
            _carService.Update(_mapper.Map<Car>(cars));
            return NoContent();
        }

        [Route("[action]/{id}")]
        [HttpDelete]
        public void DeleteCarById(int id)
        {
            _carService.DeleteById(id);
        }

    }
}
