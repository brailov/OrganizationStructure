using System.Collections.Generic;

namespace OrgManager.Domain.Entities
{
    public class EmployeeTask
    {             
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string text { get; set; }
        public string assignDate { get; set; }
        public string dueDate { get; set; }
    }
}
