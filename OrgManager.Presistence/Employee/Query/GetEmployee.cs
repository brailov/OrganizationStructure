using Microsoft.EntityFrameworkCore;
using OrgManager.Application.Data.Employees.Query;
using OrgManager.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgManager.Presistence.Employee.Query
{
    public class GetEmployee : IEmployeeById
    {
        private readonly AppDbContext _appDbContext;

        public GetEmployee(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Domain.Entities.Employee> Get(string firstname, string lastname, string position)
        {
            var employee = _appDbContext.Employees.FirstOrDefaultAsync(m => m.FirstName == firstname && m.LastName == lastname && m.Position == position);
            if (employee!=null && employee.IsCompletedSuccessfully) {
                var tasks = _appDbContext.EmployeesTasks
                    .Where(f => f.FirstName == firstname && f.LastName == lastname && f.Position == position)
                    .ToList();

                if (employee.Result.Tasks == null)
                    employee.Result.Tasks = new List<Domain.Entities.EmployeeTask>();
                //employee.Result.Tasks = new List<Domain.Entities.Task>();

                foreach (var p in tasks)
                {
                    Domain.Entities.EmployeeTask newtask = new Domain.Entities.EmployeeTask();
                    newtask.FirstName = firstname;
                    newtask.LastName = lastname;
                    newtask.Position = position;
                    newtask.assignDate = p.assignDate;
                    newtask.dueDate = p.dueDate;
                    newtask.text = p.text;
                    if (!employee.Result.Tasks.Contains(newtask))
                        employee.Result.Tasks.Add(newtask);
                }
            }
            return await employee;
        }
    }
}
