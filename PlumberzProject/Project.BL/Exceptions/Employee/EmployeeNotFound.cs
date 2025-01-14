using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.BL.Exceptions.Employee;

public class EmployeeNotFound : Exception, IBaseException
{
    public int Code => StatusCodes.Status404NotFound;

    public string ErrorMessage { get; }

    public EmployeeNotFound():base()
    {
        ErrorMessage = "Employee not found";
    }
    public EmployeeNotFound(string message) : base( message)
    {
        ErrorMessage = message;
    }
}
