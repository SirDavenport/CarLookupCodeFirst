using CarLookupCodeFirst.Core.Mappers;
using AutoMapper;
using CarLookupCodeFirst.Core.Models;
using CarLookupCodeFirst.Data.Models;

namespace CarLookupCodeFirst.Data.Mappers
{
    public class CarMapper : ICustomMapper
    {
        public void CreateMappings(IConfiguration configuration)
        {
            Mapper.CreateMap<Car, CarDTO>();
        }
    }
}
