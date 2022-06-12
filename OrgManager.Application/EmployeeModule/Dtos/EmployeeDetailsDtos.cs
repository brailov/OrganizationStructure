using OrgManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrgManager.Application.EmployeeModule.Dtos
{
    public class EmployeeDetailsDtos
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
     
        public ICollection<Task> AssignedTasks { get; set; }
        public ICollection<Report> ReportsToMngr { get; set; }
    }
}
