using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICarService
    {
        public Task<CarDto> Get(int id);
        public Task<int> Post(SetCarDto car);
        public Task<List<CarDto>> Get();
        public Task Delete(int id);
        public Task Put(int id,SetCarDto car);
    }
}
