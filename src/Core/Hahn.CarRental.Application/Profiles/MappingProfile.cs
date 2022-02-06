using AutoMapper;
using Hahn.CarRental.Application.DTO.Cars;
using Hahn.CarRental.Application.DTO.Rentals;
using Hahn.CarRental.Application.DTO.Users;
using Hahn.CarRental.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.CarRental.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Car, CarDto>().ReverseMap();
            CreateMap<Rental, RentalDto>().ReverseMap();
            CreateMap<Staff, StaffDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
