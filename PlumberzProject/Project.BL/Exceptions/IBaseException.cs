﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.BL.Exceptions;

public interface IBaseException
{
    int Code { get; }
    string ErrorMessage { get; }
}
