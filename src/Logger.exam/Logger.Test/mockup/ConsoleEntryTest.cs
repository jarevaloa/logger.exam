using Logger.exam.Common;
using Logger.exam.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Test.mockup
{
    public class ConsoleEntryTest:  ILoggerEntry
    {
        protected Dictionary<Enums.LogType, ConsoleColor> ConsoleColors = new Dictionary<Enums.LogType, ConsoleColor>
        {
            {Enums.LogType.Message, ConsoleColor.White},
            {Enums.LogType.Warning, ConsoleColor.Yellow},
            {Enums.LogType.Error, ConsoleColor.Red}
        };
        public ConsoleColor currentConsoleColor;
        public string currentMessage;
        public new void Save(string message, Enums.LogType logType) {
            if (ConsoleColors.ContainsKey(logType))
                currentConsoleColor = ConsoleColors[logType];
            currentMessage = message;
        }
    }
}
