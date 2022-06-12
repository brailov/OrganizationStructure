using OrgManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace OrgManager.Persistence
{
    public interface ISampleData { System.Threading.Tasks.Task SeedDataAsync(); }

    public class SampleData : ISampleData, IDisposable
    {
        private readonly AppDbContext _appDbContext;

        public SampleData(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async System.Threading.Tasks.Task SeedDataAsync()
        {
            try
            {
                var _EmployeeCEO = new Employee
                {
                    FirstName = "Big",
                    LastName = "Boss",
                    Position = "CEO",
                    //Tasks = new List<Domain.Entities.Task>()
                };
                _appDbContext.Employees.Add(_EmployeeCEO);
                var _Employee = new Employee
                {
                    FirstName = "Donald",LastName = "Trump",Position = "day-worker",
                    Tasks = new List<Domain.Entities.EmployeeTask>()                    
                };
                _appDbContext.Employees.Add(_Employee);

                var _EmployeeTask1 = new EmployeeTask
                {
                    FirstName = "Donald", LastName = "Trump", Position = "day-worker", text = "H.W1", assignDate = "26/03/2022", dueDate = "26/03/2022"
                };
                _appDbContext.EmployeesTasks.Add(_EmployeeTask1);

                var _EmployeeTask2 = new EmployeeTask
                {
                    FirstName = "Donald", LastName = "Trump",Position = "day-worker", text = "H.W2", assignDate = "27/03/2022", dueDate = "28/03/2022"
                };
                _appDbContext.EmployeesTasks.Add(_EmployeeTask2);

                var _Employee2 = new Employee
                {
                    FirstName = "George",
                    LastName = "Washington",
                    Position = "blacksmith",
                    //Tasks = new List<Domain.Entities.Task>()                  
                };
                _appDbContext.Employees.Add(_Employee2);

                var _EmployeeTask3 = new EmployeeTask
                {
                    FirstName = "George", LastName = "Washington", Position = "blacksmith", text = "H.W1", assignDate = "22/03/2022", dueDate = "22/03/2022"
                };
                _appDbContext.EmployeesTasks.Add(_EmployeeTask3);

                var _EmployeeTask4 = new EmployeeTask
                {
                    FirstName = "George", LastName = "Washington", Position = "blacksmith", text="H.W2", assignDate="21/03/2022", dueDate="21/03/2022"
                };
                _appDbContext.EmployeesTasks.Add(_EmployeeTask4);

                _appDbContext.Tasks.Add(new Task
                {
                    text="H.W3", assignDate="24/03/2022", dueDate="24/03/2022"
                });

                var _Manager = new Manager
                {
                    FirstName = "Bob",
                    LastName = "Shwartz",
                    SubReports = new List<Report>(),
                    MyEmployees = new List<Employee>(),
                };
                _appDbContext.Managers.Add(_Manager);

                var _mngrSubordinate = new MngrSubordinate
                {
                    MngrFirstName = "Bob", MngrLastName = "Shwartz", FirstName = "George",LastName = "Washington",Position = "blacksmith"
                };
                _appDbContext.MngrSubordinates.Add(_mngrSubordinate);

                await _appDbContext.SaveChangesAsync();
            }
            catch(Exception ex)
            {                
                throw ex;
            }
        }

        public void Dispose()
        {
            _appDbContext.Dispose();
        }
    }
}
