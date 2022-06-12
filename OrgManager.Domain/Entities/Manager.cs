
using System.Collections.Generic;


namespace OrgManager.Domain.Entities
{
    public class Manager
    {       
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Report> SubReports { get; set; }
        public ICollection<Employee> MyEmployees { get; set; }

        //public ICollection<Manager> MyManagers { get; set; }
        //public ICollection<Task> AssignedTasks { get; set; }

    }
}
