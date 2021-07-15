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
        public Task<int> Add(CarDto car);
        public Task<List<CarDto>> GetCars();
        public Task Delete(int id);
        public Task Update(int id,CarDto car);
    }
}
