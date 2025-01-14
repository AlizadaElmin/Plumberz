using Plumberz.BL.ViewModels.DepartmentVMs;
using Plumberz.BL.ViewModels.EmployeeVMs;
using Plumberz.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.BL.Services.Abstracts;

public interface IDepartmentService
{
    Task CreateDepartment(DepartmentCreateVM dto);
    Task<ICollection<DepartmentVM>> GetDepartments();
    Task<DepartmentVM> GetDepartment(int id);
    Task DeleteDepartment(int id);
    Task UpdateDepartment(int id, DepartmentUpdateVM dto);
}
