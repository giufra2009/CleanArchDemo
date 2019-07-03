using Autofac;
using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CleanArch.Infra.IoC
{
   public class DependencyContainer: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CourseService>().AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType<CourseRepository>().AsImplementedInterfaces().InstancePerLifetimeScope();
        }

       
        //public static void RegisterServices(IServiceCollection services)
        //{
        //    //Application Layer
        //    services.AddScoped<ICourseService, CourseService>();

        //    //Infra.Data Layer
        //    services.AddScoped<ICourseRepository, CourseRepository>();



        //}
    }
}
