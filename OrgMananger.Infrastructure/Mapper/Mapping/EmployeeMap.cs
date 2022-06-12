using AutoMapper;
using OrgManager.Application.EmployeeModule.Dtos;
using OrgManager.Application.EmployeeTaskModule.Dtos;
using OrgManager.Domain.Entities;
using System.Threading.Tasks;

namespace OrgManager.Infrastructure.Mapper.Mapping
{
    public class EmployeeMap : Profile
    {
        public EmployeeMap()
        {
            
            CreateMap<Employee, EmployeeDetailsDtos>()
              .ForMember(d => d.FirstName, s => s.MapFrom(x => x.FirstName))
              .ForMember(d => d.LastName, s => s.MapFrom(x => x.LastName))
              .ForMember(d => d.Position, s => s.MapFrom(x => x.Position))
              .ForMember(d => d.AssignedTasks, s => s.MapFrom(x => x.Tasks));
            CreateMap<EmployeeDetailsDtos, Employee>()
            .ForMember(d => d.FirstName, s => s.MapFrom(x => x.FirstName))
            .ForMember(d => d.LastName, s => s.MapFrom(x => x.LastName))
            .ForMember(d => d.Position, s => s.MapFrom(x => x.Position))
            .ForMember(d => d.Tasks, s => s.MapFrom(x => x.AssignedTasks));
            //.ForMember(d => d.ReportsToMngr, s => s.MapFrom(x => x.ReportsToMngr)); ;
            
            CreateMap<Employee, EmployeeDtos>();
            CreateMap <EmployeeDtos, Employee>()
            .ForMember(d => d.FirstName, s => s.MapFrom(x=>x.FirstName))
            .ForMember(d => d.LastName, s => s.MapFrom(x => x.LastName))
            .ForMember(d => d.Position, s => s.MapFrom(x => x.Position));

            CreateMap<EmployeeTaskDtos, EmployeeTask>();
            CreateMap<EmployeeTask, EmployeeTaskDtos>();
        }
    }
}
