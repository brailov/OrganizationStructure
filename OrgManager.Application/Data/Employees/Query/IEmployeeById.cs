using OrgManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrgManager.Application.Data.Employees.Query
{
    public interface IEmployeeById
    {
        Task<Employee> Get(string? firstname, string? lastname, string? position);        
    }
}
