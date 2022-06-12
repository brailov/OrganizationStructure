using OrgManager.Application.Data.Mnanager.Query;
using OrgManager.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrgManager.Presistence.Manager.Query
{
    class GetManangerSubordinates : IGetManangerSubordinates
    {
        private readonly AppDbContext _appDbContext;

        public GetManangerSubordinates(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Domain.Entities.MngrSubordinate>> Get(string firstname, string lastname)
        {
            return null;
            //var tasks = _appDbContext.MngrSubordinate
            //       .Where(f => f.)
            //       .ToList();

            //if (employee.Result.Tasks == null)
            //    employee.Result.Tasks = new List<Domain.Entities.Task>();

            //foreach (var p in tasks)
            //{
            //    Domain.Entities.Task newtask = new Domain.Entities.Task();
            //    newtask.assignDate = p.assignDate;
            //    newtask.dueDate = p.dueDate;
            //    newtask.text = p.text;
            //    if (!employee.Result.Tasks.Contains(newtask))
            //        employee.Result.Tasks.Add(newtask);
            //}
            //return await tasks;
        }
    }
}
