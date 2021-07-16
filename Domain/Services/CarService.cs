using AutoMapper;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Entities;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CarService(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<int> Post(SetCarDto car)
        {
            var carEntity = _mapper.Map<CarEntity>(car);
            return await _carRepository.Post(carEntity);
        }

        public async Task Delete(int id)
        {
            await _carRepository.Delete(id);
        }

        public async Task<CarDto> Get(int id)
        {
            var result = await _carRepository.Get(id);
            var carDto = _mapper.Map<CarDto>(result);
            return carDto;
        }

        public async Task<List<CarDto>> Get()
        {
            var result = await _carRepository.Get();
            var carsDto = _mapper.Map<List<CarDto>>(result);
            return carsDto;
        }

        public async Task Put(int id, SetCarDto car)
        {
            var carEntity = _mapper.Map<CarEntity>(car);
            await _carRepository.Put(id, carEntity);
        }
    }
}
