﻿using System.Reflection;
using CarLookupCodeFirst.Core.Mappers;
using System.Collections.Generic;
using System.Linq;
using System;
using AutoMapper;

namespace CarLookupCodeFirst.Web.Mappers
{
    public static class AutoMapperConfig
    {
        public static void Execute()
        {
            Services.Mappers.AutoMapperConfig.Execute();
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();
            LoadCustomMappings(types);
        }

        private static void LoadCustomMappings(IEnumerable<Type> types)
        {
            var maps = (from t in types
                        from i in t.GetInterfaces()
                        where typeof(ICustomMapper).IsAssignableFrom(t) &&
                        !t.IsAbstract &&
                        !t.IsInterface
                        select (ICustomMapper)Activator.CreateInstance(t)).ToArray();
            foreach (var map in maps)
            {
                map.CreateMappings(Mapper.Configuration);
            };
        }
    }
}
