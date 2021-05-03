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
    public class InsuranceController : ControllerBase
    {
        IInsuranceService _ınsuranceService;
        IMapper _mapper;
        public InsuranceController(IInsuranceService ınsuranceService, IMapper mapper)
        {
            _ınsuranceService = ınsuranceService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllInsurance()
        {
            var ınsurances = _ınsuranceService.GetAll();
            return Ok(_mapper.Map<IEnumerable<InsurancesDto>>(ınsurances));
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdInsurance(int id)
        {
            var ınsurance = _ınsuranceService.GetById(id);
            return Ok(_mapper.Map<InsurancesDto>(ınsurance));
        }

        [HttpPost]
        public IActionResult AddInsurance([FromBody]InsurancesDto ınsurancesDto)
        {
            _ınsuranceService.Add(_mapper.Map<Insurance>(ınsurancesDto));
            return Created(string.Empty, null);
        }

        [HttpPut]
        public IActionResult UpdateInsurance([FromBody] InsurancesDto ınsurancesDto)
        {
            _ınsuranceService.Update(_mapper.Map<Insurance>(ınsurancesDto));
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteInsurance([FromBody]InsurancesDto ınsurancesDto)
        {
            _ınsuranceService.Delete(_mapper.Map<Insurance>(ınsurancesDto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteByIdInsurance(int id)
        {
            _ınsuranceService.DeleteById(id);
            return NoContent();
        }
    }
}
