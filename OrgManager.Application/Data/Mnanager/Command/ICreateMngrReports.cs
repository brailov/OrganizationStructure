using OrgManager.Domain.Entities;

namespace OrgManager.Application.Data.Mnanager.Command
{
    public interface ICreateMngrReports
    {
        System.Threading.Tasks.Task Create(MngrReports mngrReport);
    }
}
