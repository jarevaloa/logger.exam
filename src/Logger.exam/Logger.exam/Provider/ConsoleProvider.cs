﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.exam.Common;
using Logger.exam.Logger;

namespace Logger.exam
{
    public class ConsoleProvider : FormatProvider
    {
        private ILoggerEntry _loggerEntry;
        public ConsoleProvider(ILoggerEntry loggerEntry) {
            _loggerEntry = loggerEntry;
        }
        public override void Write(string message, Enums.LogType logType)
        {
            _loggerEntry.Save(string.Format("{0} {1}", DateTime.Now.ToShortDateString(), message), logType);
        }
    }
}
