using OrgManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrgManager.Application.Data.Mnanager.Query
{
    public interface IGetManangerSubordinates
    {
        Task<List<MngrSubordinate>> Get(string mngrfirstname, string mngrlastname);
    }
}
