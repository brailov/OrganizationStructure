using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OrgManager.Application.EmployeeModule.Dtos;
using OrgManager.Application.EmployeeModule.Service.Interfaces;
using OrgManager.Application.EmployeeTaskModule.Dtos;
using OrgManager.Application.EmployeeTaskModule.Service.Interfaces;
using OrgManager.Application.ManagerModule.Dtos;
using OrgManager.Domain.Entities;
using Task = System.Threading.Tasks.Task;

namespace orgManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeSrv;
        private readonly IEmployeeTaskService _employeeTaskSrv;

        public EmployeeController(            
            IEmployeeService employeeSrv,
            IEmployeeTaskService employeeTaskSrv)
        {         
            _employeeSrv = employeeSrv;
            _employeeTaskSrv = employeeTaskSrv;
        }


        [HttpGet]
        public IEnumerable<EmployeeDtos> Get()
        {
            return _employeeSrv.GetAllEmployees();
           
        }

        [HttpGet("byName")] 
        public EmployeeDetailsDtos Get(string firstname, string lastname, string position)
        {
            return _employeeSrv.GetEmployeeById(firstname, lastname, position);

        }

        [HttpPut("Task")]
        public string Put(EmployeeTaskDtos _taskKey)
        {
            try
            {
                //var x = _employeeTaskSrv.CreateTaskToEmployee(_taskKey);
                return "ok";
            }
            catch (Exception ex)
            {
                return "Exception";
            }
        }
    }
}
