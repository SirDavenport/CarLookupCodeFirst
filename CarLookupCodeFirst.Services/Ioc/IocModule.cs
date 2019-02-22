using Autofac;
using CarLookupCodeFirst.Services.Interfaces;

namespace CarLookupCodeFirst.Services.Ioc
{
    public class IocModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new Data.Ioc.IocModule());
            builder.RegisterType<CarService>().As<ICarService>();
        }
    }
}
