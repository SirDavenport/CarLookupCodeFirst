using Autofac;
using CarLookupCodeFirst.Data.DAL;
using CarLookupCodeFirst.Data.DAL.Interfaces;
using CarLookupCodeFirst.Data.Repository;
using CarLookupCodeFirst.Data.Repository.Interfaces;

namespace CarLookupCodeFirst.Data.Ioc
{
    public class IocModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new Core.Ioc.IocModule());
            builder.RegisterType<CarLookupContext>().As<ICarLookupContext>().InstancePerRequest();
            builder.RegisterType<CarRepository>().As<ICarRepository>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
        }
    }
}
