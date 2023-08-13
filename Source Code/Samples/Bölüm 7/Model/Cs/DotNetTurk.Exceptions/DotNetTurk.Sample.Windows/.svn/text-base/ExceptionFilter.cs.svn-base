using System;
using System.Collections.Generic;
using System.Text;
using DotNetTurk.Exceptions;

namespace DotNetTurk.Sample.Windows
{
    class ExceptionFilter: IExceptionFilter
    {
        public bool Filter(Exception exc)
        {
            if (exc is ApplicationSecurityException)
                return true;
            else if (exc is UserException)
                return false;
            else if (exc is TechnicalException)
                return true;
            else
                return true;
        }
    }
}
