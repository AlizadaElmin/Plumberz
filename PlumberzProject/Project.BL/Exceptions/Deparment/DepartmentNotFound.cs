using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.BL.Exceptions.Deparment;

public class DepartmentNotFound : Exception, IBaseException
{
    public int Code => StatusCodes.Status404NotFound;

    public string ErrorMessage { get; }

    public DepartmentNotFound() : base()
    {
        ErrorMessage = "Department not found";
    }

    public DepartmentNotFound(string message) : base(message)
    {
        ErrorMessage = message;
    }
}
