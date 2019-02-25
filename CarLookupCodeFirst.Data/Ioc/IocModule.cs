using Autofac;
using CarLookupCodeFirst.Data.DAL;
using CarLookupCodeFirst.Data.Repository;
using CarLookupCodeFirst.Data.Repository.Interfaces;

namespace CarLookupCodeFirst.Data.Ioc
{
    public class IocModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new Core.Ioc.IocModule());
            builder.RegisterType<CarLookupContext>().InstancePerLifetimeScope();
            builder.RegisterType<CarRepository>().As<ICarRepository>();
        }
    }
}
