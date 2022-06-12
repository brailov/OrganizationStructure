using Microsoft.EntityFrameworkCore;
using OrgManager.Application.Data.Employees.Query;
using OrgManager.Application.EmployeeModule.Dtos;
using OrgManager.Persistence;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrgManager.Presistence.Employee.Query
{
    public class AllEmployees : IAllEmployee
    {
        private readonly AppDbContext _appDbContext;

        public AllEmployees(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Domain.Entities.Employee>> Get()
        {
            return await _appDbContext.Employees.ToListAsync();
        }       

    }
}
