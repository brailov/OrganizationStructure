using Microsoft.AspNetCore.Mvc;
using OrgManager.Application.ManagerModule.Dtos;
using OrgManager.Application.ManagerModule.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace orgManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManagerController : ControllerBase
    {     
        private readonly IManagerService _mngrSrv;

        public ManagerController(
            IManagerService mngrSrv)
        {
            _mngrSrv = mngrSrv;
        }

        [HttpGet]
        public IEnumerable<ManagerDtos> Get()
        {
            return null;

        }

        [HttpGet("byName")]
        public ManagerDtos Get(string firstname, string lastname, string position)
        {
            return _mngrSrv.GetManagerByEmployee(firstname, lastname, position);

        }

        [HttpPut]
        public string Put(MngrReportsDtos employeeReportKey)
        {
            try
            {
                var x = _mngrSrv.SendManagerReportToEmployee(employeeReportKey);
                return "ok";
            }
            catch(Exception ex)
            {
                return "Exception";
            }
        }


    }
}
