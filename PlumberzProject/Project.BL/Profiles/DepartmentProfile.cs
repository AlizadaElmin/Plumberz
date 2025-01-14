using AutoMapper;
using Plumberz.BL.ViewModels.DepartmentVMs;
using Plumberz.BL.ViewModels.EmployeeVMs;
using Plumberz.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.BL.Profiles;

public class DepartmentProfile : Profile
{
    public DepartmentProfile()
    {
        CreateMap<DepartmentCreateVM, Department>();
        CreateMap<DepartmentUpdateVM, Department>();
        CreateMap<Department, DepartmentVM>();
    }
}
