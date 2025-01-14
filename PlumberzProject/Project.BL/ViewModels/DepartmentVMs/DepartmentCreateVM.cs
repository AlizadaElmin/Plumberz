using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.BL.ViewModels.DepartmentVMs;

public class DepartmentCreateVM
{
    [MaxLength(64)]
    public string Name { get; set; }
}
