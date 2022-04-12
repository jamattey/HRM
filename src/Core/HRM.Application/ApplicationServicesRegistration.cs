using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using HRM.Application.Profiles;
using MediatR;

namespace HRM.Application
{
    public class ApplicationServicesRegistration
    {
        public static IServiceCollection ConfigurationApplicationServices(this IServiceCollection services)
        {
            services.AddAutomapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}