using CarLookupCodeFirst.Data.Models;
using System.Collections.Generic;

namespace CarLookupCodeFirst.Data.DAL
{
    public class CarLookupInitializer : System.Data.Entity.DropCreateDatabaseAlways<CarLookupContext>
    {
        protected override void Seed(CarLookupContext context)
        {
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
            var cars = new List<Car>
            {
                new Car
                {
                    Maker = "Dodge",
                    Model = "Charger",
                    Year = "1968",
                    BodyTypes = new List<BodyType>
                    {
                        bodyTypes[0],
                        bodyTypes[1]
                    }
                },
                new Car
                {
                    Maker = "Chevy",
                    Model = "Camaro",
                    Year = "1968",
                    BodyTypes = new List<BodyType>
                    {
                        bodyTypes[0],
                        bodyTypes[1]
                    }
                },
                new Car
                {
                    Maker = "Ford",
                    Model = "Mustang",
                    Year = "1968",
                    BodyTypes = new List<BodyType>
                    {
                        bodyTypes[0],
                        bodyTypes[1]
                    }
                },
                new Car
                {
                    Maker = "Subaru",
                    Model = "Crosstrek",
                    Year = "2016",
                    BodyTypes = new List<BodyType>
                    {
                        bodyTypes[3],
                        bodyTypes[4]
                    }
                }
            };

            bodyTypes.ForEach(b => context.BodyTypes.Add(b));
            cars.ForEach(c => context.Cars.Add(c));
            context.SaveChanges();
        }
    }
}
