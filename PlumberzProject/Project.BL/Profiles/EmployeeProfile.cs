using AutoMapper;
using Plumberz.BL.ViewModels.EmployeeVMs;
using Plumberz.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.BL.Profiles;

public class EmployeeProfile : Profile
{
    public EmployeeProfile()
    {
        CreateMap<EmployeeCreateVM, Employee>();
        CreateMap<EmployeeUpdateVM, Employee>();
        CreateMap<Employee, EmployeeVM>();
    }
}
