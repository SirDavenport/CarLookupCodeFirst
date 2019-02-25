using CarLookupCodeFirst.Data.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using CarLookupCodeFirst.Data.DAL.Interfaces;

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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
