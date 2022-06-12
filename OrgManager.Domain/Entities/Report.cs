using System;
using System.Collections.Generic;
using System.Text;

namespace OrgManager.Domain.Entities
{
    public class Report
    {
        public string text { get; set; }
        public string date { get; set; }

        public Employee FromEmployee { get; set; }
        public Manager ToManager { get; set; }
    }
}
