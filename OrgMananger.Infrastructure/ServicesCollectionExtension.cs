using AutoMapper;
using OrgManager.Application.EmployeeModule.Service;
using OrgManager.Application.EmployeeModule.Service.Interfaces;
using OrgManager.Domain.Logger;
using OrgManager.Domain.Mapper;
using OrgManager.Infrastructure.Logger;
using OrgManager.Infrastructure.Mapper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using OrgManager.Application.ManagerModule.Services.Interfaces;
using OrgManager.Application.ManagerModule.Services;
using OrgManager.Application.EmployeeTaskModule.Service.Interfaces;
using OrgManager.Application.EmployeeTaskModule.Service;

namespace OrgManager.Infrastructure
{
    public static class ServicesCollectionExtension
    {
        public static void AddInrustractureLayerServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // Custom Logger Adapter to abstract Logger dependicy from Core layers.
            services.AddSingleton(typeof(ILoggerAdapter<>), typeof(LoggerAdapter<>));

            // Custom Mapper Adapter to abstract Mapper dependicy from Core layers.
            services.AddSingleton<IMapperAdapter, MapperAdapter>();

            // application services
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IEmployeeTaskService, EmployeeTaskService>();
            services.AddTransient<IManagerService, ManagerService>();
        }
    }
}
