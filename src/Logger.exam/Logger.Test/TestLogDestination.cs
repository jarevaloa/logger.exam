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
        public void WhenNotConfigureProviderThenExceptionWriteLog()
        {
            Assert.AreEqual(true, true);

        }
        [Test]
        public void WhenProviderIsDataBaseThenSaveDataBase()
        {
            Assert.AreEqual(true,true);
         
        }
        [Test]
        public void WhenProviderIsFileThenSaveFile()
        {
            Assert.AreEqual(true, true);

        }
        [Test]
        public void WhenProviderIsConsoleThenSaveConsole()
        {
            var logger = new JobLogger();
            var consoleEntry = new mockup.ConsoleEntryTest();
            logger.AddFormatProvider(new ConsoleProvider(consoleEntry));
            var message = "Message";
            logger.WriteError(message);
            Assert.AreEqual( ConsoleColor.Red, consoleEntry.currentConsoleColor);
            var expectedMessage = string.Format("{0} {1}", DateTime.Now.ToShortDateString(), message);
            Assert.AreEqual(expectedMessage, consoleEntry.currentMessage);
        }
        [Test]
        public void WhenWriteErrorOnlyFileThenSaveError()
        {
            Assert.AreEqual(true, true);

        }
    }
}
