using Autofac;
using DbFirst;
using RepositoryInterfaces;
using Respositories;
using ServiceInterfaces;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Bootstrapper
    {
        public static IContainer container;

        public static IContainer RegisterTypes()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ProjectZeroDbContext>().AsSelf().InstancePerLifetimeScope();

            builder.RegisterType<LoggingService>().As<ILoggingService>();

            builder.RegisterType<RestaurantRepository>().As<IRestaurantRepository>();

            builder.RegisterType<RestaurantService>().As<IRestaurantService>();

            builder.RegisterType<Application>().As<IApplication>();

            container = builder.Build();

            return container;

        }
    }
}
