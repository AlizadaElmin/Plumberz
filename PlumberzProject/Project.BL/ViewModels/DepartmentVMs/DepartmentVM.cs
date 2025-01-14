using Plumberz.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.BL.ViewModels.DepartmentVMs;

public class DepartmentVM
{
    public string Name { get; set; }
    public ICollection<Employee> Employees { get; set; }
}