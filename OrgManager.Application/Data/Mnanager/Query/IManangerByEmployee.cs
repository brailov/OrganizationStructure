using OrgManager.Domain.Entities;
using System.Threading.Tasks;

namespace OrgManager.Application.Data.Mnanager.Query
{
    public interface IManangerByEmployee
    {
        Task<Manager> Get(string? firstname, string? lastname, string? position);     
    }
}
