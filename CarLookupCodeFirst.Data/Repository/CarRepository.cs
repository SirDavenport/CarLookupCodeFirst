using AutoMapper.QueryableExtensions;
using CarLookupCodeFirst.Core.Models;
using CarLookupCodeFirst.Data.DAL;
using CarLookupCodeFirst.Data.Models;
using CarLookupCodeFirst.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLookupCodeFirst.Data.Repository
{
    public class CarRepository : ICarRepository
    {
        private CarLookupContext _db;

        public CarRepository(CarLookupContext db)
        {
            _db = db;
        }

        public string AddCar(Car car)
        {
            _db.Cars.Add(car);
            _db.SaveChanges();
            return "Created";
        }

        public string DeleteCar(int id)
        {
            Car car = _db.Cars.Find(id);
            _db.Cars.Remove(car);
            _db.SaveChanges();
            return "Deleted";
        }

        public string EditCar(Car car)
        {
            _db.Entry(car).State = EntityState.Modified;
            _db.SaveChanges();
            return "Edited";
        }

        public ICollection<Car> GetAll()
        {
            return _db.Cars.ToList<Car>();
        }

        public Car GetCar(int? id)
        {
            Car car = _db.Cars.Find(id);
            if (car == null)
            {
                return null;
            }
            List<string> bodyTypes = (from cb in _db.CarBodyTypes
                                      join bb in _db.BodyTypes on cb.BodyTypeID equals bb.ID
                                      where cb.CarID == id
                                      select bb.Name).ToList<string>();
            car.BodyTypeNames = bodyTypes;
            return car;
        }
    }
}
