using Plumberz.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.Core.Models;

public class Employee : BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string ImageUrl { get; set; }
    public Department Department { get; set; }
    public int DepartmentId { get; set; }
    public int Role { get; set; } = (int)Roles.User;
}
