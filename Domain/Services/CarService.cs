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

        public async Task Add(CarDto car)
        {
            var carEntity = _mapper.Map<CarEntity>(car);
            await _carRepository.Add(carEntity);
        }

        public async Task Delete(int id)
        {
            await _carRepository.Delete(id);
        }

        public async Task<CarDto> GetCarById(int id)
        {
            var result = await _carRepository.GetCarById(id);
            var carDto = _mapper.Map<CarDto>(result);
            return carDto;
        }

        public async Task<List<CarDto>> GetCars()
        {
            var result = await _carRepository.GetCars();
            List<CarDto> carsDto = new List<CarDto>();
            foreach (var item in result)
            {
                carsDto.Add(_mapper.Map<CarDto>(item));
            }
            return carsDto;
        }

        public async Task Update(int id,CarDto car)
        {
            var carEntity = _mapper.Map<CarEntity>(car);
            await _carRepository.Update(id,carEntity);
        }
    }
}
