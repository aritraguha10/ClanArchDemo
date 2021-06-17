using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Data.Repository;
using CleanArch.Domain.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServcies(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
