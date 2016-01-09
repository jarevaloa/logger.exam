using Logger.exam.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.exam.Logger
{
    public interface ILoggerEntry
    {
        void Save(string message, Enums.LogType logType);
    }
}
