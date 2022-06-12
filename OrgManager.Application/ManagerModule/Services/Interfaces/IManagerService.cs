using OrgManager.Application.ManagerModule.Dtos;
using OrgManager.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrgManager.Application.ManagerModule.Services.Interfaces
{
    public interface IManagerService
    {
        ManagerDtos GetManagerByEmployee(string? firstname, string? lastname, string? position);
        System.Threading.Tasks.Task SendManagerReportToEmployee(MngrReportsDtos objMngr);
        List<MngrSubordinate> GetManangerSubordinates(string mngrfirstname, string mngrlastname);
    }
}
