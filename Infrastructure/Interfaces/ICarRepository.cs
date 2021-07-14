using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface ICarRepository
    {
        public Task<CarEntity> GetCarById(int id);
        public Task Add(CarEntity car);
        public Task<IEnumerable<CarEntity>> GetCars();
        public Task Delete(int id);
        public Task Update(int id,CarEntity car);
    }
}
