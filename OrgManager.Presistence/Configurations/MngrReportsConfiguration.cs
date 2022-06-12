using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrgManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrgManager.Presistence.Configurations
{
    class MngrReportsConfiguration : IEntityTypeConfiguration<Domain.Entities.MngrReports>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.MngrReports> builder)
        {
            builder.HasKey(c => new { c.EmpFirstName, c.EmpLastName, c.EmpPosition, c.MngrFirstName, c.MngrLastName ,c.text, c.date});

        }
       
    }
}
