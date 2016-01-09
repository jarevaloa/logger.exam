using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.exam
{
    public class JobLogger
    {
        private readonly IList<FormatProvider> providers;
        public JobLogger() {
            providers = new List<FormatProvider>();
        }
        public void AddFormatProvider(FormatProvider formatProvider) {
            providers.Add(formatProvider);
        }
        public bool HasProvider() {
            return providers.Count > 0;

        }
        public void WriteMessage(string message)
        {
            Write(message, Common.Enums.LogType.Message);
        }
        public void WriteWarning(string message)
        {
            Write(message, Common.Enums.LogType.Warning);
        }
        public void WriteError(string message)
        {
            Write(message, Common.Enums.LogType.Error);
        }
        public void Write(string message, Common.Enums.LogType logType) {
            if (!HasProvider())
                return;
            foreach (var provider in providers)
            {
                provider.Write(message,logType);
            }
        }
    }
}
