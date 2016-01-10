using Logger.exam;
namespace Logger.Test
{
    using System;
    using NUnit.Framework;
    using exam.Logger;
    [TestFixture]
    public class TestLogDestination
    {
        [Test]
        public void WhenNotConfigureProviderThenNoHasProvider()
        {
            var logger = new JobLogger();
            Assert.IsFalse(logger.HasProvider());

        }
        [Test]
        [ExpectedException(typeof(Exception), ExpectedMessage = "Invalid configuration")]
        public void WhenNotConfigureProviderAndYouTryToWriteErrorThenExceptionInvalidConfiguration()
        {
            var logger = new JobLogger();
            var consoleEntry = new mockup.ConsoleEntryTest();
            var message = "Message";
            logger.WriteError(message);

        }
        [Test]
        public void WhenProviderIsDataBaseThenSaveDataBase()
        {
            var logger = new JobLogger();
            var entryDataBase = new mockup.DataBaseEntryTest();
            logger.AddFormatProvider(new DataBaseProvider(entryDataBase));
            var message = "Message error save in DataBase";
            logger.WriteError(message);
            var expectedMessage = message;
            Assert.AreEqual(expectedMessage, entryDataBase.GetResults()[0].Message);
            Assert.AreEqual(Logger.exam.Common.Enums.LogType.Error, entryDataBase.GetResults()[0].LogType);

        }
        [Test]
        public void WhenProviderIsFileAndWriteMessageThenSaveFile()
        {
            var logger = new JobLogger();
            var entry = new mockup.FileEntryTest();
            logger.AddFormatProvider(new FileProvider(entry));
            var message = "Message";
            logger.WriteError(message);
            var expectedMessage = string.Format("{0}: {1}", DateTime.Now.ToShortDateString(), message);
            Assert.AreEqual(expectedMessage, entry.GetResults()[0].Message);
            Assert.AreEqual(Logger.exam.Common.Enums.LogType.Error, entry.GetResults()[0].LogType);
        }
        [Test]
        public void WhenProviderIsConsoleThenSaveConsole()
        {
            var logger = new JobLogger();
            var consoleEntry = new mockup.ConsoleEntryTest();
            logger.AddFormatProvider(new ConsoleProvider(consoleEntry));
            var message = "Message";
            logger.WriteError(message);
            var expectedMessage = string.Format("{0} {1}", DateTime.Now.ToShortDateString(), message);
            Assert.AreEqual(expectedMessage, consoleEntry.GetResults()[0].Message);
            Assert.AreEqual(Logger.exam.Common.Enums.LogType.Error, consoleEntry.GetResults()[0].LogType);

        }
        [Test]
        public void WhenWriteErrorOnlyFileThenSaveError()
        {
            var logger = new JobLogger();
            var entry = new mockup.FileEntryTest();
            logger.AddFormatProvider(new FileProvider(entry));
            var message = "Message";
            logger.WriteError(message);
            var expectedMessage = string.Format("{0}: {1}", DateTime.Now.ToShortDateString(), message);
            Assert.AreEqual(expectedMessage, entry.GetResults()[0].Message);
            Assert.AreEqual(Logger.exam.Common.Enums.LogType.Error, entry.GetResults()[0].LogType);
        }
    }
}
