
using AutoMapper;
using OrgManager.Application.ManagerModule.Dtos;
using OrgManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrgMananger.Infrastructure.Mapper.Mapping
{
    public class ManagerMap : Profile
    {
        public ManagerMap()
        {
            CreateMap<Manager, ManagerDtos>();
            CreateMap<ManagerDtos, Manager>();

            CreateMap<MngrReports, MngrReportsDtos>();
            CreateMap<MngrReportsDtos, MngrReports>();
        }
    }
}
