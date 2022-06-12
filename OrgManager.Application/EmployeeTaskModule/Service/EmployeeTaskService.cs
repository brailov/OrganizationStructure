using OrgManager.Application.Data.Employees.Query;
using OrgManager.Application.Data.EmployeeTask.Command;
using OrgManager.Application.EmployeeTaskModule.Dtos;
using OrgManager.Application.EmployeeTaskModule.Service.Interfaces;
using OrgManager.Domain.Entities;
using OrgManager.Domain.Logger;
using OrgManager.Domain.Mapper;
using System;


namespace OrgManager.Application.EmployeeTaskModule.Service
{
    public class EmployeeTaskService : IEmployeeTaskService
    {
        private readonly ICreateEmployeeTask _createEmployeeTask;     
        private readonly IMapperAdapter _mapperAdapter;
        private readonly ILoggerAdapter<EmployeeTaskService> _logger;

        public EmployeeTaskService(
         ICreateEmployeeTask createEmployeeTask,
         IEmployeeById _EmployeeTaskById,
         IMapperAdapter mapperAdapter,
         ILoggerAdapter<EmployeeTaskService> logger)
        {
            _createEmployeeTask = createEmployeeTask;          
            _mapperAdapter = mapperAdapter;
            _logger = logger;
        }

        public System.Threading.Tasks.Task CreateTaskToEmployee(EmployeeTaskDtos employeeTaskDtos)
        {
            try
            {
                var newEmployeeTask = _mapperAdapter.Map<EmployeeTask>(employeeTaskDtos);
                return _createEmployeeTask.Create(newEmployeeTask);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Method CreatelActivityLogs failed");
                throw;
            }
        }

        public EmployeeTaskDtos GetEmployeeTaskById(string firstname, string lastname, string position)
        {
            try
            {
                //var data = _getEmployeeTaskById.Get(firstname, lastname, position);
                //if (data != null && data.IsCompletedSuccessfully)
                //{
                //    var resData = data.Result;
                //    return _mapperAdapter.Map<EmployeeTaskDtos>(resData);
                //}
                return null;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Method GetEmployeeById failed");
                throw;
            }
        }

    }
}
