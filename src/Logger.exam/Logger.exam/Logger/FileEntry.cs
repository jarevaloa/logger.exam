using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.exam.Common;
using System.Configuration;
using System.IO;

namespace Logger.exam.Logger
{
    public class FileEntry : ILoggerEntry
    {
        private string _fileLocation;
        private string _filePath; 
        public FileEntry()
        {
            _fileLocation = ConfigurationManager.AppSettings["LogFileDirectory"];
            _filePath = string.Format("{0}LogFile_{1:yyyy-MM-dd}.txt", _fileLocation, DateTime.Now);
        }

        public void Save(string message, Enums.LogType logType)
        {
          
            File.AppendAllText(_filePath, string.Format("{0}{1}",  message,Environment.NewLine));
        }

    

    }
}
