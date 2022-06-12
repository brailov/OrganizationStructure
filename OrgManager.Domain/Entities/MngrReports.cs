using System;
using System.Collections.Generic;
using System.Text;

namespace OrgManager.Domain.Entities
{
    public class MngrReports
    {
        public string MngrFirstName { get; set; }
        public string MngrLastName { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public string EmpPosition { get; set; }
        public string text { get; set; }
        public string date { get; set; }
    }
}
