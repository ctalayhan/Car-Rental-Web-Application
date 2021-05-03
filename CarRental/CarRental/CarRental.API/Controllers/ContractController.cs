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

namespace CarRental.API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ContractController : ControllerBase {
        IContractService _contractService;
        IMapper _mapper;

        public ContractController(IContractService contractService, IMapper mapper) {
            _contractService = contractService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GettAllContracts() {
            var contracts = _contractService.GetAll();
            if (contracts!=null || (!contracts.Any())) {
                return Ok(_mapper.Map<IEnumerable<ContractsDto>>(contracts));
            } else {
                return NoContent();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GettByIdContracts(int id)
        {
            var contracts = _contractService.GetById(id);

                return Ok(_mapper.Map<ContractsDto>(contracts));

        }

        [HttpPost]
        public IActionResult AddContract([FromBody] ContractsDto contracts) {
            _contractService.Add(_mapper.Map<Contract>(contracts));
            return Created(string.Empty, null);
        }

        [HttpPut]
        public IActionResult UpdateContract([FromBody] ContractsDto contracts) {
            _contractService.Update(_mapper.Map<Contract>(contracts));
            return NoContent();
        }


        [HttpDelete]
        public IActionResult DeleteContract([FromBody] ContractsDto contracts) {
            _contractService.Delete(_mapper.Map<Contract>(contracts));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContractById(int contractId) {
            _contractService.DeleteById(contractId);
            return NoContent();
        }
    }
}
