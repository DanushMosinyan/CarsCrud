﻿using Infrastructure.Entities;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly IGenericRepository<CarEntity> _carRepo;
        public CarRepository(IGenericRepository<CarEntity> carRepo)
        {
            _carRepo = carRepo;
        }

        public async Task<int> Add(CarEntity car)
        {
            var query = "INSERT INTO Cars(Description,Image) OUTPUT INSERTED.ID VALUES(@Description,@Image);";
            return await _carRepo.Add(query, car);
        }

        public async Task<IEnumerable<CarEntity>> GetCars()
        {
            string sQuery = @"SELECT * FROM Cars";
            var result = await _carRepo.GetAll(sQuery);
            return result;
        }

        public async Task<CarEntity> GetCarById(int id)
        {
            var query = "SELECT * FROM Cars WHERE Id = @Id";
            var param = new { Id = id };
            var result = await _carRepo.GetById(query, param);
            return result;
        }

        public async Task Delete(int id)
        {
            string sQuery = @"DELETE FROM Cars WHERE Id = @Id";
            await _carRepo.Delete(sQuery, new { Id = id });
        }

        public async Task Put(int id, CarEntity car)
        {
            string query = @"UPDATE Cars SET Description = @Description,Image = @Image WHERE Id = @Id";
            await _carRepo.Put(query, new { Id = id, Description = car.Description, Image = car.Image });
        }
    }
}
