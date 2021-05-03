using AutoMapper;
using CarRental.BLL.Abstract;
using CarRental.DTO.DTOs;
using CarRental.Entity.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRental.API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase {
        IDiscountService _discountService;
        IMapper _mapper;

        public DiscountController(IDiscountService discountService,
        IMapper mapper) {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllDiscounts() {
            var discounts = _discountService.GetAll();
            if (discounts != null || (!discounts.Any())) {
                return Ok(_mapper.Map<IEnumerable<DiscountsDto>>(discounts));
            } else {
                return NoContent();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdDiscounts(int id)
        {
            var discounts = _discountService.GetById(id);

                return Ok(_mapper.Map<DiscountsDto>(discounts));

        }

        [HttpPost]
        public IActionResult AddDiscount([FromBody] DiscountsDto discounts) {
            _discountService.Add(_mapper.Map<Discount>(discounts));
            return Created(string.Empty, null);
        }

        [HttpPut]
        public IActionResult UpdateDiscount([FromBody] DiscountsDto discounts) {
            _discountService.Update(_mapper.Map<Discount>(discounts));
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteDiscount([FromBody] DiscountsDto discounts) {
            _discountService.Delete(_mapper.Map<Discount>(discounts));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDiscountById(int discountId) {
            _discountService.DeleteById(discountId);
            return NoContent();
        }


    }
}
