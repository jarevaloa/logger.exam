using Logger.exam.Common;
using Logger.exam.Logger;
using System;

namespace Logger.exam
{
    public class FileProvider : FormatProvider
    {
        private ILoggerEntry _loggerEntry;
        public FileProvider(ILoggerEntry loggerEntry)
        {
            _loggerEntry = loggerEntry;
        }
        public override void Write(string message, Enums.LogType logType)
        {
            _loggerEntry.Save(string.Format("{0}: {1}", DateTime.Now.ToShortDateString(), message), logType);
        }
    }
}
