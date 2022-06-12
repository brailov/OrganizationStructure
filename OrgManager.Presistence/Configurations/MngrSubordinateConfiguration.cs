using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrgManager.Presistence.Configurations
{
    class MngrSubordinateConfiguration : IEntityTypeConfiguration<Domain.Entities.MngrSubordinate>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.MngrSubordinate> builder)
        {
            builder.HasKey(c => new { c.FirstName, c.LastName, c.Position });                    
        }
    }
}
