using Logger.exam.Exceptions;
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
            try
            {
                if (!HasProvider())
                    throw new CustomExeption("Invalid configuration");
                foreach (var provider in providers)
                {
                    provider.Write(message, logType);
                }
            }
            catch (CustomExeption)
            {
                throw;
            }
            catch (Exception ex) {
                // save in another entry for exception and throw custom exception 
                throw new CustomExeption("oh no! I'm afraid about that. you can tell me after.");
            }
        }
    }
}
