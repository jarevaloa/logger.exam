using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.exam;
namespace Logger.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var loggerDataBase = new JobLogger();
            loggerDataBase.AddFormatProvider(new DataBaseProvider(new Logger.exam.Logger.DataBaseEntry()));
            loggerDataBase.WriteError("example write error in database");
            loggerDataBase.WriteMessage("example write message in database");
            loggerDataBase.WriteWarning("example write warning in database");

            var loggerFile = new JobLogger();
            loggerFile.AddFormatProvider(new FileProvider(new Logger.exam.Logger.FileEntry()));
            loggerFile.WriteError("example write error in file");
            loggerFile.WriteMessage("example write message in file");
            loggerFile.WriteWarning("example write warning in file");

            var loggerConsole = new JobLogger();
            loggerConsole.AddFormatProvider(new ConsoleProvider(new Logger.exam.Logger.ConsoleEntry()));
            loggerConsole.WriteError("example write error in console");
            loggerConsole.WriteMessage("example write message in console");
            loggerConsole.WriteWarning("example write warning in console");

            var loggerAllProvider = new JobLogger();
            loggerAllProvider.AddFormatProvider(new ConsoleProvider(new Logger.exam.Logger.ConsoleEntry()));
            loggerAllProvider.AddFormatProvider(new FileProvider(new Logger.exam.Logger.FileEntry()));
            loggerAllProvider.AddFormatProvider(new DataBaseProvider(new Logger.exam.Logger.DataBaseEntry()));

            loggerAllProvider.WriteError("example write error in console, database and file");
            loggerAllProvider.WriteMessage("example write message console, database and file");
            loggerAllProvider.WriteWarning("example write warning console, database and file");
        }
    }
}
