using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.exam
{
    public abstract class FormatProvider
    {
                public abstract void Write(string message, Common.Enums.LogType logType);
    }
}
