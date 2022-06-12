using OrgManager.Application.Data.Employees.Query;
using OrgManager.Application.EmployeeModule.Dtos;
using OrgManager.Application.EmployeeModule.Service.Interfaces;
using OrgManager.Domain.Logger;
using OrgManager.Domain.Mapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrgManager.Application.EmployeeModule.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IAllEmployee _getAllEmployees;
        private readonly IEmployeeById _getEmployeeById;
        private readonly IMapperAdapter _mapperAdapter;
        private readonly ILoggerAdapter<EmployeeService> _logger;

        public EmployeeService(
         IEmployeeById employeeById,
         IAllEmployee allEmployees,        
         IMapperAdapter mapperAdapter,
         ILoggerAdapter<EmployeeService> logger)
        {
            _getEmployeeById = employeeById;
            _getAllEmployees = allEmployees;                     
            _mapperAdapter = mapperAdapter;
            _logger = logger;
        }

        public List<EmployeeDtos> GetAllEmployees()
        {
            try
            {
                var data = _getAllEmployees.Get();
                if(data != null && data.IsCompletedSuccessfully)
                {                  
                    var resData = data.Result;
                    return _mapperAdapter.Map<List<EmployeeDtos>>(resData);
                }
                return null;
                             
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Method GetAllEmployees failed");
                throw;
            }
        }

        public EmployeeDetailsDtos GetEmployeeById(string firstname, string lastname, string position)
        {
            try
            {
                var data = _getEmployeeById.Get(firstname, lastname, position);
                if (data != null && data.IsCompletedSuccessfully)
                {
                    var resData = data.Result;
                    var resDataMapped = _mapperAdapter.Map<EmployeeDetailsDtos>(resData);
                    return resDataMapped;
                }
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
