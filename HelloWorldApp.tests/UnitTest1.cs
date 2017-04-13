using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldApp;

namespace HelloWorldApp.tests
{
    [TestClass]
    public class FactoryUnitTests
    {
        [TestMethod]
        public void ValidConsoleWriter()
        {
            WriterFactory w = new WriterFactory("Console");
            Assert.IsInstanceOfType(w.GetWriter(), typeof(Writers.ConsoleWriter));
        }

        [TestMethod]
        public void ValidFileWriter()
        {
            WriterFactory w = new WriterFactory("File");
            Assert.IsInstanceOfType(w.GetWriter(), typeof(Writers.FileWriter));
        }

        [TestMethod]
        public void ValidDBWriter()
        {
            WriterFactory w = new WriterFactory("DB");
            Assert.IsInstanceOfType(w.GetWriter(), typeof(Writers.DBWriter));
        }
    }
}
