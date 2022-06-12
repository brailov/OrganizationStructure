using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrgManager.Presistence.Configurations
{
    public class EmployeeTaskConfiguaration : IEntityTypeConfiguration<Domain.Entities.EmployeeTask>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.EmployeeTask> builder)
        {
            builder.HasKey(c => new { c.FirstName, c.LastName, c.Position ,c.text ,c.assignDate, c.dueDate });            
        }
    }
}
