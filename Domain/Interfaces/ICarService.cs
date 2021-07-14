using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICarService
    {
        public Task<CarDto> GetCarById(int id);
        public Task Add(CarDto car);
        public Task<List<CarDto>> GetCars();
        public Task Delete(int id);
        public Task Update(int i,CarDto car);
    }
}
