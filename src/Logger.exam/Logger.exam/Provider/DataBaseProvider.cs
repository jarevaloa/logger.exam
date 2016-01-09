using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.exam.Common;
using Logger.exam.Logger;

namespace Logger.exam
{
    public class DataBaseProvider : FormatProvider
    {

        private ILoggerEntry _loggerEntry;
        public DataBaseProvider(ILoggerEntry loggerEntry)
        {
            _loggerEntry = loggerEntry;
        }
        public override void Write(string message, Enums.LogType logType)
        {
            _loggerEntry.Save(message, logType);
        }
    }
}
