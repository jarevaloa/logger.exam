using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.exam.Common;

namespace Logger.exam.Logger
{
    public class ConsoleEntry : ILoggerEntry
    {
        private Dictionary<Enums.LogType, ConsoleColor> ConsoleColors = new Dictionary<Enums.LogType, ConsoleColor>
        {
            {Enums.LogType.Message, ConsoleColor.White},
            {Enums.LogType.Warning, ConsoleColor.Yellow},
            {Enums.LogType.Error, ConsoleColor.Red}
        };
        public void Save(string message, Enums.LogType logType)
        {
            if (ConsoleColors.ContainsKey(logType))
                Console.ForegroundColor = ConsoleColors[logType];
            Console.WriteLine(string.Format("{0} {1}", DateTime.Now.ToShortDateString(), message));
            
        }

    }
}
