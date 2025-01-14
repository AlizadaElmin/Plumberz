using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.BL.ViewModels.EmployeeVMs;

public class EmployeeVM
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string ImageUrl { get; set; }
    public int DepartmentId { get; set; }
}
