﻿using CarLookupCodeFirst.Core.Models;
using CarLookupCodeFirst.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLookupCodeFirst.Services.Interfaces
{
    public interface ICarService
    {
        string AddCar(Car car);

        string DeleteCar(int id);

        string EditCar(Car car);

        Car GetCar(int? id);

        ICollection<Car> GetCars();

        CarLookupContext GetDb();
    }
}
