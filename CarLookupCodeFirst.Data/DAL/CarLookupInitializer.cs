using CarLookupCodeFirst.Core.Models;
using System.Collections.Generic;

namespace CarLookupCodeFirst.Data.DAL
{
    public class CarLookupInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CarLookupContext>
    {
        protected override void Seed(CarLookupContext context)
        {
            var cars = new List<Car>
            {
                new Car
                {
                    Maker = "Dodge",
                    Model = "Charger",
                    Year = "1968"
                },
                new Car
                {
                    Maker = "Chevy",
                    Model = "Camaro",
                    Year = "1968"
                },
                new Car
                {
                    Maker = "Ford",
                    Model = "Mustang",
                    Year = "1968"
                },
                new Car
                {
                    Maker = "Subaru",
                    Model = "Crosstrek",
                    Year = "2016"
                }
            };
            cars.ForEach(c => context.Cars.Add(c));
            context.SaveChanges();

            var bodyTypes = new List<BodyType>
            {
                new BodyType
                {
                    Name = "Sedan"
                },
                new BodyType
                {
                    Name = "Coupe"
                },
                new BodyType
                {
                    Name = "SUV"
                },
                new BodyType
                {
                    Name = "Minivan"
                },
                new BodyType
                {
                    Name = "Crossover"
                }
            };
            bodyTypes.ForEach(b => context.BodyTypes.Add(b));
            context.SaveChanges();

            var carBodyTypes = new List<CarBodyType>
            {
                new CarBodyType
                {
                    BodyTypeID = 1,
                    CarID = 1
                },
                new CarBodyType
                {
                    BodyTypeID = 2,
                    CarID = 1
                },
                new CarBodyType
                {
                    BodyTypeID = 1,
                    CarID = 2
                },
                new CarBodyType
                {
                    BodyTypeID = 2,
                    CarID = 2
                },
                new CarBodyType
                {
                    BodyTypeID = 1,
                    CarID = 3
                },
                new CarBodyType
                {
                    BodyTypeID = 2,
                    CarID = 3
                },
                new CarBodyType
                {
                    BodyTypeID = 5,
                    CarID = 4
                }
            };
            carBodyTypes.ForEach(cb => context.CarBodyTypes.Add(cb));
            context.SaveChanges();
        }
    }
}
