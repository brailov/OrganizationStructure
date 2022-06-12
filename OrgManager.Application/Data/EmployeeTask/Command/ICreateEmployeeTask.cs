

using System.Threading.Tasks;

namespace OrgManager.Application.Data.EmployeeTask.Command
{
    public interface ICreateEmployeeTask
    {
        Task Create(Domain.Entities.EmployeeTask _empTask);
    }
}
