using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _carService.Get();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _carService.Get(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<int> Post([FromBody] SetCarDto car)
        {
            return await _carService.Post(car);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] SetCarDto car)
        {
            await _carService.Put(id,car);
            return Ok();
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _carService.Delete(id);
        }
    }
}
