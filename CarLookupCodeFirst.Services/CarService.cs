using CarLookupCodeFirst.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLookupCodeFirst.Core.Models;
using CarLookupCodeFirst.Data.DAL;
using System.Data.Entity;

namespace CarLookupCodeFirst.Services
{
    public class CarService : ICarService
    {
        private CarLookupContext db = new CarLookupContext();

        public string AddCar(Car car)
        {
            db.Cars.Add(car);
            db.SaveChanges();
            return "Created";
        }

        public string DeleteCar(int id)
        {
            Car car = db.Cars.Find(id);
            db.Cars.Remove(car);
            db.SaveChanges();
            return "Deleted";
        }

        public string EditCar(Car car)
        {
            db.Entry(car).State = EntityState.Modified;
            db.SaveChanges();
            return "Edited";
        }

        public Car GetCar(int? id)
        {
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return null;
            }
            List<string> bodyTypes = (from cb in db.CarBodyTypes
                                      join bb in db.BodyTypes on cb.BodyTypeID equals bb.ID
                                      where cb.CarID == id
                                      select bb.Name).ToList<string>();
            car.BodyTypeNames = bodyTypes;
            return car;
        }

        public ICollection<Car> GetCars()
        {
            return db.Cars.ToList();
        }
    }
}
