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
    public class EmployeeController : ControllerBase
    {
        IEmployeeService _employeeService;
        IMapper _mapper;
        public EmployeeController(IEmployeeService employeeService, IMapper mapper)
        {
            _mapper = mapper;
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetAllEmployee()
        {
            var employees = _employeeService.GetAll();
            return Ok(_mapper.Map<IEnumerable<EmployeesDto>>(employees));
        }

        [Route("[action]")]
        [HttpGet]
        public IActionResult AddEmployee()
        {
            var employee = _employeeService.GetEmployeeAddInfo();
            return Ok(_mapper.Map<EmployeeAddDto>(employee));
        }

        [Route("[action]")]
        [HttpGet]
        public IActionResult GetAllEmployeeBasicInfo()
        {
            var employees = _employeeService.GetEmployeeBasicInfo();
            return Ok(employees);
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public IActionResult GetEmployeeDetailedInfo(int id)
        {
            var employees = _employeeService.GetEmployeeDetailedInfo(id);
            return Ok(employees);
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public IActionResult GetEmployeeUpdateInfo(int id)
        {
            var employees = _employeeService.GetEmployeeUpdateInfo(id);
            return Ok(employees);
        }


        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _employeeService.GetById(id);
            return Ok(_mapper.Map<EmployeesDto>(employee));
        }
        [HttpPost]
        public IActionResult AddEmployee([FromBody] EmployeesDto employeesDto)
        {
            _employeeService.Add(_mapper.Map<Employee>(employeesDto));
            return Created(string.Empty, null);
        }

        [HttpPut]
        public IActionResult UpdateEmployee([FromBody] EmployeesDto employeesDto)
        {
            _employeeService.Update(_mapper.Map<Employee>(employeesDto));
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteEmployee([FromBody] EmployeesDto employeesDto)
        {
            _employeeService.Delete(_mapper.Map<Employee>(employeesDto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteByIdEmployee(int id)
        {
            _employeeService.DeleteById(id);
            return NoContent();
        }
    }
}
