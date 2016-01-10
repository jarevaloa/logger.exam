using Logger.exam.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.exam.Common;

namespace Logger.Test.mockup
{
    public class ConsoleEntryWithErrorTest : ILoggerEntry
    {
        public void Save(string message, Enums.LogType logType)
        {
            throw new Exception ("don't find forecolour..");
        }
    }
}
