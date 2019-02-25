using CarLookupCodeFirst.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLookupCodeFirst.Data.Repository.Interfaces
{
    public interface ICarRepository
    {
        String AddCar(Car car);

        String DeleteCar(int id);

        String EditCar(Car car);

        ICollection<Car> GetAll();

        Car GetCar(int? id);
    }
}
