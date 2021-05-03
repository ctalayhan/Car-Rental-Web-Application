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
    public class BrandModelDetailController : ControllerBase
    {
        IBrandModelDetailService _brandModelDetailService;
        IMapper _mapper;


        public BrandModelDetailController(IBrandModelDetailService brandModelDetailService, IMapper mapper)
        {
            _brandModelDetailService = brandModelDetailService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllBrandModelDetails()
        {
            var brandModelDetails = _brandModelDetailService.GetAll();
            if (brandModelDetails != null || (!brandModelDetails.Any()))
            {
                return Ok(_mapper.Map<IEnumerable<BrandModelDetailsDto>>(brandModelDetails));
            }
            else
            {
                return NoContent();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdBrandModelDetails(int id)
        {
            var brandModelDetails = _brandModelDetailService.GetById(id);

            return Ok(_mapper.Map<BrandModelDetailsDto>(brandModelDetails));

        }

        [HttpPost]
        public IActionResult AddBrandModelDetail([FromBody] BrandModelDetailsDto brandModelDetails)
        {
            _brandModelDetailService.Add(_mapper.Map<BrandModelDetail>(brandModelDetails));
            return Created(string.Empty, null);
        }

        [HttpPut]
        public IActionResult UpdateBrandModelDetail([FromBody] BrandModelDetailsDto brandModelDetails)
        {
            _brandModelDetailService.Update(_mapper.Map<BrandModelDetail>(brandModelDetails));
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteBrandModelDetail([FromBody] BrandModelDetailsDto brandModelDetails)
        {
            _brandModelDetailService.Delete(_mapper.Map<BrandModelDetail>(brandModelDetails));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBrandModelDetailById(int brandModelDetailId)
        {
            _brandModelDetailService.DeleteById(brandModelDetailId);
            return NoContent();
        }

    }
}
