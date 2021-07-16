﻿using Domain.Interfaces;
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
        public async Task<IActionResult> GetCars()
        {
            var result = await _carService.GetCars();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarById(int id)
        {
            var result = await _carService.GetCarById(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<int> Post([FromBody] SetCarDto car)
        {
            return await _carService.Add(car);
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
