using OrgManager.Application.Data.Employees.Query;
using OrgManager.Application.Data.Mnanager.Command;
using OrgManager.Application.Data.Mnanager.Query;
using OrgManager.Application.ManagerModule.Dtos;
using OrgManager.Application.ManagerModule.Services.Interfaces;
using OrgManager.Domain.Entities;
using OrgManager.Domain.Logger;
using OrgManager.Domain.Mapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrgManager.Application.ManagerModule.Services
{
    public class ManagerService: IManagerService
    {
        private readonly ICreateMngrReports _createMngrReports;
        private readonly IGetManangerSubordinates _getMngrSubordinates;
        private readonly IEmployeeById _employeeById;
        private readonly IManangerByEmployee _getManagerByEmp;
        private readonly IMapperAdapter _mapperAdapter;
        private readonly ILoggerAdapter<ManagerService> _logger;    

        public ManagerService(
         IGetManangerSubordinates getMngrSubordinates,
         ICreateMngrReports createMngrReports,
         IManangerByEmployee getManagerByEmp,
         IEmployeeById employeeById,
         IMapperAdapter mapperAdapter,
         ILoggerAdapter<ManagerService> logger)
        {
            _getMngrSubordinates = getMngrSubordinates;
            _createMngrReports = createMngrReports;
            _employeeById = employeeById;
            _getManagerByEmp = getManagerByEmp;
            _mapperAdapter = mapperAdapter;
            _logger = logger;
        }

        public System.Threading.Tasks.Task SendManagerReportToEmployee(MngrReportsDtos _mngr)
        {            
            try
            {
                var newMngrReports = _mapperAdapter.Map<MngrReports>(_mngr);
                return _createMngrReports.Create(newMngrReports);                                                          
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Method SendManagerReportToEmployee failed");
                throw;
            }
        }

        public ManagerDtos GetManagerByEmployee(string firstname, string lastname, string position)
        {
            try
            {
                var data = _getManagerByEmp.Get(firstname, lastname, position);
                if (data != null && data.IsCompletedSuccessfully)
                {
                    var manager = data.Result;
                    var employee = _employeeById.Get(firstname, lastname, position);
                    if (employee != null && employee.IsCompletedSuccessfully)
                    {
                        var resEmployee = employee.Result;                      
                        if (manager.MyEmployees.Contains(resEmployee))
                            manager.MyEmployees.Remove(resEmployee);
                        manager.MyEmployees.Add(resEmployee);
                    }
                    
                    var managerMapped = _mapperAdapter.Map<ManagerDtos>(manager);            
                    return managerMapped;
                }
                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Method GetCustomer failed");
                throw;
            }
        }

        public List<MngrSubordinate> GetManangerSubordinates(string mngrfirstname, string mngrlastname)
        {
            var data = _getMngrSubordinates.Get(mngrfirstname, mngrlastname);
            if (data != null && data.IsCompletedSuccessfully)
            {
                return data.Result;       
            }
            return null;
        }
    }
}
