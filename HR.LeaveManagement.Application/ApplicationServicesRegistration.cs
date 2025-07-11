﻿using HR.LeaveManagement.Application.Profiles;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace HR.LeaveManagement.Application
{
    public static class ApplicationServicesRegistration
    {
        public static void ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
