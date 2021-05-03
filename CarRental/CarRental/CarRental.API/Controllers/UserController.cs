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
    public class UserController : ControllerBase
    {
        IUserService _userService;
        IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            _mapper = mapper;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userService.GetAll();
            return Ok(_mapper.Map<IEnumerable<UsersDto>>(users));
        }

        [HttpGet("{id}")]
        public IActionResult GetUserId(int id)
        {
            var user = _userService.GetById(id);
            return Ok(_mapper.Map<UsersDto>(user));
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] UsersDto usersDto)
        {
            _userService.Add(_mapper.Map<User>(usersDto));

            return Created(string.Empty, null);
        }

        [HttpPut]
        public IActionResult UpdateUser([FromBody] UsersDto usersDto)
        {
            _userService.Update(_mapper.Map<User>(usersDto));

            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteUser([FromBody] UsersDto usersDto)
        {
            _userService.Delete(_mapper.Map<User>(usersDto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteByIdUser(int id)
        {
            _userService.DeleteById(id);
            return NoContent();
        }

    }
}

