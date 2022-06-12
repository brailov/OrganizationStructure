using OrgManager.Application.Data.Employees.Query;
using OrgManager.Presistence.Employee.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrgManager.Application.Data.Mnanager.Query;
using OrgManager.Presistence.Manager.Query;
using OrgManager.Application.Data.Mnanager.Command;
using OrgManager.Presistence.Employee.Command;
using OrgManager.Application.Data.EmployeeTask.Command;
using OrgManager.Presistence.EmployeeTask.Command;

namespace OrgManager.Persistence
{
    public static class ServicesCollectionExtension
    {
        public static void AddPersistanceLayerServices(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("OrgManagerDataBase"));

            // data services
            services.AddTransient<ISampleData, SampleData>();
            services.AddTransient<IEmployeeById, GetEmployee>();
            services.AddTransient<IAllEmployee, AllEmployees>();
            services.AddTransient<IManangerByEmployee, GetManagerByEmployee>();
            services.AddTransient<IGetManangerSubordinates, GetManangerSubordinates>();
            services.AddTransient<ICreateMngrReports , CreateMngrReport>();
            services.AddTransient<ICreateEmployeeTask, CreateEmployeeTask>();                                   
        }
    }
}
