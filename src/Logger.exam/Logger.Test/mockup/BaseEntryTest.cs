using Logger.exam.Logger;
using Logger.Test.Interface;
using System;
using System.Collections.Generic;
using Logger.Test.Entity;
using Logger.exam.Common;

namespace Logger.Test.mockup
{
    public class BaseEntryTest : ILoggerEntry, ISuccessResultTest
    {
        private List<TestResult> resultSuccess;
        public BaseEntryTest() {
            resultSuccess = new List<TestResult>();
        }
        public List<TestResult> GetResults()
        {
            return resultSuccess;
        }

        void ILoggerEntry.Save(string message, Enums.LogType logType)
        {
            resultSuccess.Add(new TestResult() { Message = message, LogType = logType });
        }
    }
}
