using AutoMapper.QueryableExtensions;
using CarLookupCodeFirst.Core.Models;
using CarLookupCodeFirst.Data.DAL;
using CarLookupCodeFirst.Data.DAL.Interfaces;
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
        private ICarLookupContext _db;
        private IUnitOfWork _unitOfWork;

        public CarRepository(ICarLookupContext db, IUnitOfWork unitOfWork)
        {
            _db = db;
            _unitOfWork = unitOfWork;
        }

        public string AddCar(Car car)
        {
            _db.Cars.Add(car);
            _unitOfWork.SaveChanges();
            return "Created";
        }

        public string DeleteCar(int id)
        {
            Car car = _db.Cars.Find(id);
            _db.Cars.Remove(car);
            _unitOfWork.SaveChanges();
            return "Deleted";
        }

        public string EditCar(Car car)
        {
            Car originalCar = _db.Cars.Find(car.ID);
            originalCar.Maker = car.Maker;
            originalCar.Model = car.Model;
            originalCar.Year = car.Year;
            _unitOfWork.SaveChanges();
            return "Edited";
        }

        public ICollection<Car> GetAll()
        {
            return _db.Cars.ToList();
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
