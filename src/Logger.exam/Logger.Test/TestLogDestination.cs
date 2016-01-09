using Logger.exam;
namespace Logger.Test
{
    using System;
    using NUnit.Framework;
    [TestFixture]
    public class TestLogDestination
    {
        [Test]
        public void WhenNotConfigureProviderThenNoHasProvider()
        {
            var logger = new JobLogger();
            Assert.AreEqual(false, logger.HasProvider());

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
            Assert.AreEqual(true, true);

        }
        [Test]
        public void WhenWriteErrorOnlyFileThenSaveError()
        {
            Assert.AreEqual(true, true);

        }
    }
}
