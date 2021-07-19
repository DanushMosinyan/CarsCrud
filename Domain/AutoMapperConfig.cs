using AutoMapper;
using Domain.Models;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CarDto, CarEntity>().ReverseMap();
            CreateMap<SetCarDto, CarEntity>().ReverseMap();
        }
    }
}
