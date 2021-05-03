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
    public class ModelController : ControllerBase
    {
        IModelService _modelService;
        IMapper _mapper;
        public ModelController(IModelService modelService, IMapper mapper)
        {
            _mapper = mapper;
            _modelService = modelService;
        }

        [HttpGet]
        public IActionResult GetAllModel()
        {
            var models = _modelService.GetAll();
            return Ok(_mapper.Map<IEnumerable<ModelsDto>>(models));
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdModel(int id)
        {
            var model = _modelService.GetById(id);
            return Ok(_mapper.Map<ModelsDto>(model));
        }

        [HttpPost]
        public IActionResult AddModel([FromBody] ModelsDto modelsDto)
        {
            _modelService.Add(_mapper.Map<Model>(modelsDto));
            return Created(string.Empty, null);
        }

        [HttpPut]
        public IActionResult UpdateModel([FromBody] ModelsDto modelsDto)
        {
            _modelService.Update(_mapper.Map<Model>(modelsDto));
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteModel([FromBody] ModelsDto modelsDto)
        {
            _modelService.Delete(_mapper.Map<Model>(modelsDto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteByIdModel(int id)
        {
            _modelService.DeleteById(id);
            return NoContent();
        }
    }
}
