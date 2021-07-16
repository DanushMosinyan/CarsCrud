using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface ICarRepository
    {
        public Task<CarEntity> Get(int id);
        public Task<int> Post(CarEntity car);
        public Task<IEnumerable<CarEntity>> Get();
        public Task Delete(int id);
        public Task Put(int id, CarEntity car);
    }
}
