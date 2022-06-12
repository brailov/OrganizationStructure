using System.Collections.Generic;

namespace OrgManager.Domain.Entities
{
    public class Employee
    {             
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

        public ICollection<EmployeeTask> Tasks { get; set; }    
        
    }
}
