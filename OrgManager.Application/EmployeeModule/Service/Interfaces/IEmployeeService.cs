using OrgManager.Application.EmployeeModule.Dtos;
using OrgManager.Application.ManagerModule.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrgManager.Application.EmployeeModule.Service.Interfaces
{
    public interface IEmployeeService
    {
        List<EmployeeDtos> GetAllEmployees();
        EmployeeDetailsDtos GetEmployeeById(string? firstname, string? lastname, string? position);    
    }
}
