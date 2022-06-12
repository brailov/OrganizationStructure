using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrgManager.Presistence.Configurations
{
    public class ReportConfiguration : IEntityTypeConfiguration<Domain.Entities.Report>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Report> builder)
        {
            builder.HasKey(c => new { c.date, c.text });
        }
    }
}
