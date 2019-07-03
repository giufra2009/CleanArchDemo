using Autofac;
using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.CommandHandler;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Bus;
using CleanArch.Infra.Data.Repository;
using MediatR;
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
            builder.RegisterType<IMediatorHandler>().As<InMemoryBus>().InstancePerLifetimeScope();
            builder.RegisterType<IRequestHandler<CreateCourseCommand, bool>>().As<CourseCommandHandler>().InstancePerLifetimeScope();
           
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
