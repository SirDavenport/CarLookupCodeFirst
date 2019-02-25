using Autofac;
using CarLookupCodeFirst.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLookupCodeFirst.Data.Ioc
{
    public class IocModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new Core.Ioc.IocModule());
            builder.RegisterType<CarLookupContext>().InstancePerLifetimeScope();
        }
    }
}
