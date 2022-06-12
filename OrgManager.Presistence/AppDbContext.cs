using OrgManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace OrgManager.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
        { }
        
        public DbSet<Employee> Employees { get; set; }      
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<EmployeeTask> EmployeesTasks { get; set; }
        public DbSet<MngrSubordinate> MngrSubordinates { get; set; }
        public DbSet<MngrReports> MngrReports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>()
            //              //.Navigation(b => b.Tasks)
            //              .UsePropertyAccessMode(PropertyAccessMode.Property);
            //modelBuilder.Entity<Manager>()
            //              //.Navigation(b => b.Tasks)
            //              .UsePropertyAccessMode(PropertyAccessMode.Property);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
           
        }
    }
}