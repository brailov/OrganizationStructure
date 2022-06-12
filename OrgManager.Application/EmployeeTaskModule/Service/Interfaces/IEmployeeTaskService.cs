using OrgManager.Application.EmployeeTaskModule.Dtos;
using OrgManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrgManager.Application.EmployeeTaskModule.Service.Interfaces
{
    public interface IEmployeeTaskService
    {
        EmployeeTaskDtos GetEmployeeTaskById(string? firstname, string? lastname, string? position);
        System.Threading.Tasks.Task CreateTaskToEmployee(EmployeeTaskDtos employeeTaskDtos);
    }
}
