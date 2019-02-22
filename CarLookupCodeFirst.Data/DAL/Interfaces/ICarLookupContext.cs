using CarLookupCodeFirst.Core.Models;
using System.Data.Entity;

namespace CarLookupCodeFirst.Data.DAL.Interfaces
{
    public interface ICarLookupContext
    {
        DbSet<BodyType> BodyTypes { get; set; }
        DbSet<CarBodyType> CarBodyTypes { get; set; }
        DbSet<Car> Cars { get; set; }

        int saveChanges();
    }
}
