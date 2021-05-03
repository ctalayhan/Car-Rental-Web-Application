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
    public class CarBrandController : ControllerBase
    {
        ICarBrandService _carBrandService;
        IMapper _mapper;
        // GET: CarBrandController
        public CarBrandController(ICarBrandService carBrandService,
        IMapper mapper)
        {
            _carBrandService = carBrandService;
            _mapper = mapper;

        }
        [HttpGet]
        public IActionResult GetAllCarBrands()
        {
            var carBrands = _carBrandService.GetAll();
            if (carBrands != null || (!carBrands.Any()))
            {
                return Ok(_mapper.Map<IEnumerable<CarBrandsDto>>(carBrands));
            }
            else
            {
                return NoContent();
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetByIdCarBrands(int id)
        {
            var carBrands = _carBrandService.GetById(id);

            return Ok(_mapper.Map<CarBrandsDto>(carBrands));


        }

        [HttpPost]
        public IActionResult AddCarBrand([FromBody] CarBrandsDto carBrands)
        {
            _carBrandService.Add(_mapper.Map<CarBrand>(carBrands));
            return Created(string.Empty, null);
        }

        [HttpPut]
        public IActionResult UpdateCarBrand([FromBody] CarBrandsDto carBrands)
        {
            _carBrandService.Update(_mapper.Map<CarBrand>(carBrands));
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteCarBrand([FromBody] CarBrandsDto carBrands)
        {
            _carBrandService.Delete(_mapper.Map<CarBrand>(carBrands));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCarBrandById(int carBrandId)
        {
            _carBrandService.DeleteById(carBrandId);
            return NoContent();

        }

    }
}
