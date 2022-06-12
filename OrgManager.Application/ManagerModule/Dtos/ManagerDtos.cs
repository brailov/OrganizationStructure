using OrgManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrgManager.Application.ManagerModule.Dtos
{
    public class ManagerDtos
    {        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Report> SubReports { get; set; }
        public ICollection<Employee> MyEmployees { get; set; }

        //public ICollection<Manager> MyManagers { get; set; }
        //public ICollection<Task> AssignedTasks { get; set; }

    }
}
