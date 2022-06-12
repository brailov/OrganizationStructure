using OrgManager.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrgManager.Application.Data.Employees.Query
{
    public interface IAllEmployee
    {       
        Task<List<Employee>> Get();        
    }
}
