using Plumberz.BL.ViewModels.EmployeeVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.BL.Services.Abstracts;

public interface IEmployeeService
{
    Task CreateEmployee(EmployeeCreateVM dto, string destination);
    Task<ICollection<EmployeeVM>> GetEmployees();
    Task<EmployeeVM> GetEmployee(int id);
    Task DeleteEmployee(int id);
    Task UpdateEmployee(int id,EmployeeUpdateVM dto, string? destination);

}
