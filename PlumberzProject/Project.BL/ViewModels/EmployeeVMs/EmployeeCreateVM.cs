using Microsoft.AspNetCore.Http;
using Plumberz.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.BL.ViewModels.EmployeeVMs;

public class EmployeeCreateVM
{
    [MaxLength(16)]
    public string Name { get; set; }
    [MaxLength(32)]
    public string Surname { get; set; }
    [MaxLength(255)]
    public IFormFile Image { get; set; }
    public int DepartmentId { get; set; }
}
