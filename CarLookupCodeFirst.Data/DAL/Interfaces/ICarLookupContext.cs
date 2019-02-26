using CarLookupCodeFirst.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLookupCodeFirst.Data.DAL.Interfaces
{
    public interface ICarLookupContext : IDisposable
    {
        DbSet<BodyType> BodyTypes { get; set; }
        DbSet<Car> Cars { get; set; }

        int SaveChanges();
    }
}
