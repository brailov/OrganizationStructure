using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrgManager.Presistence.Configurations
{
    public class ManangerConfiguration : IEntityTypeConfiguration<Domain.Entities.Manager>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Manager> builder)
        {
            builder.HasKey(c => new { c.FirstName, c.LastName });
            //builder.HasMany(b => b.SubReports).WithOne(); //Single navigation property

        }
    }
}
