using CarLookupCodeFirst.Services.Interfaces;
using System.Collections.Generic;
using CarLookupCodeFirst.Data.Models;
using CarLookupCodeFirst.Data.Repository.Interfaces;

namespace CarLookupCodeFirst.Services
{
    public class CarService : ICarService
    {
        private ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public string AddCar(Car car)
        {
            return _carRepository.AddCar(car);
        }

        public string DeleteCar(int id)
        {
            return _carRepository.DeleteCar(id);
        }

        public string EditCar(Car car)
        {
            return _carRepository.EditCar(car);
        }

        public Car GetCar(int? id)
        {
            return _carRepository.GetCar(id);
        }

        public ICollection<Car> GetCars()
        {
            //return db.Cars.ToList();
            return _carRepository.GetAll();
        }
    }
}
