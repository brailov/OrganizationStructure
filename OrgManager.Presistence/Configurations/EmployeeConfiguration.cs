using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrgManager.Domain.Entities;

namespace OrgManager.Presistence.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Domain.Entities.Employee>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Employee> builder)
        {
            builder.HasKey(c => new { c.FirstName, c.LastName ,c.Position});
            //builder.HasMany(b => b.Tasks).WithOne(); // Single navigation property
           

        }
    }
   
}
