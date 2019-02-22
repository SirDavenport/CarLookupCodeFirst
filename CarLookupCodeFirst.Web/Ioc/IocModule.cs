using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;

namespace CarLookupCodeFirst.Web.Ioc
{
    public class IocModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new Services.Ioc.IocModule());
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterFilterProvider();
            builder.RegisterSource(new ViewRegistrationSource());
        }
    }
}
