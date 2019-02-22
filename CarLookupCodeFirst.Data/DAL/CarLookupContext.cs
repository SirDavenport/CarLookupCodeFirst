using CarLookupCodeFirst.Core.Models;
using CarLookupCodeFirst.Data.DAL.Interfaces;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System;

namespace CarLookupCodeFirst.Data.DAL
{
    public class CarLookupContext : DbContext, ICarLookupContext
    {
        public CarLookupContext() : base("CarLookupContext")
        {
        }

        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<CarBodyType> CarBodyTypes { get; set; }
        public DbSet<Car> Cars { get; set; }

        public int saveChanges()
        {
            throw new NotImplementedException();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
