using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.exam.Interface
{
    public interface  Ilogger
    {
       void WriteLog(string message, Common.Enums.LogType logType);
    }
}
