using Microsoft.EntityFrameworkCore;
using OrgManager.Application.Data.Mnanager.Query;
using OrgManager.Application.ManagerModule.Services.Interfaces;
using OrgManager.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgManager.Presistence.Manager.Query
{
    class GetManagerByEmployee : IManangerByEmployee
    {
        private readonly AppDbContext _appDbContext;

        public GetManagerByEmployee(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Domain.Entities.Manager> Get(string firstname, string lastname, string position)
        {
            var managerSubordinate = _appDbContext.MngrSubordinates.FirstOrDefaultAsync(m => m.FirstName == firstname && m.LastName == lastname && m.Position == position);
            
            if (managerSubordinate != null && managerSubordinate.IsCompletedSuccessfully)
            {                
                var manager = _appDbContext.Managers.FirstOrDefaultAsync(m => m.FirstName == managerSubordinate.Result.MngrFirstName && m.LastName == managerSubordinate.Result.MngrLastName);
                if (manager.Result != null && manager.Result.MyEmployees == null)
                {
                    manager.Result.MyEmployees = new List<Domain.Entities.Employee>();
                    var employees = _appDbContext.MngrSubordinates
                      .Where(f => f.MngrFirstName == managerSubordinate.Result.MngrFirstName && f.MngrLastName == managerSubordinate.Result.MngrLastName)
                      .ToList();

                    foreach (var p in employees)
                    {
                        Domain.Entities.Employee newEmployee = new Domain.Entities.Employee();
                        newEmployee.FirstName = p.FirstName;
                        newEmployee.LastName = p.LastName;
                        newEmployee.Position = p.Position;
                        manager.Result.MyEmployees.Add(newEmployee);
                    }
                }

                if (manager.Result != null && manager.Result.SubReports == null)
                {
                    manager.Result.SubReports = new List<Domain.Entities.Report>();
                    
                    var reports = _appDbContext.MngrReports
                      .Where(f => f.MngrFirstName == managerSubordinate.Result.MngrFirstName && f.MngrLastName == managerSubordinate.Result.MngrLastName)
                      .ToList();
                    foreach (var p in reports)
                    {
                        Domain.Entities.Report newreport = new Domain.Entities.Report();
                        newreport.date = p.date;
                        newreport.text = p.text;
                        newreport.FromEmployee = null;
                        newreport.ToManager = null;
                        manager.Result.SubReports.Add(newreport);
                    }
                }
                return await manager;
            }
            return null;
        }
    }
}
