using OrgManager.Application.Data.EmployeeTask.Command;
using OrgManager.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrgManager.Presistence.EmployeeTask.Command
{
    class CreateEmployeeTask : ICreateEmployeeTask
    {
        private readonly AppDbContext _appDbContext;

        public CreateEmployeeTask(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public System.Threading.Tasks.Task Create(Domain.Entities.EmployeeTask emptask)
        {
            _appDbContext.EmployeesTasks.Add(emptask);
            return _appDbContext.SaveChangesAsync();
        }
    }
}
