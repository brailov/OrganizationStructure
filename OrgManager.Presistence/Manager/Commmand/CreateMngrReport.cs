using OrgManager.Application.Data.Mnanager.Command;
using OrgManager.Domain.Entities;
using OrgManager.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrgManager.Presistence.Employee.Command
{
    public class CreateMngrReport : ICreateMngrReports
    {
        private readonly AppDbContext _appDbContext;

        public CreateMngrReport(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public System.Threading.Tasks.Task Create(MngrReports mngrReport)
        {
            _appDbContext.MngrReports.Add(mngrReport);
            return _appDbContext.SaveChangesAsync();
        }
    }
}
