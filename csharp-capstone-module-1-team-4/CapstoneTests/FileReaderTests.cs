using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    [TestClass]
    public class FileReaderTests
    {
        [TestMethod]
        public void UsesCorrectPath()
        {
            Assert.AreEqual(Environment.CurrentDirectory, FileReader.directoryPath);
        }

        [TestMethod]
        public void GetsCorrectFile()
        {
            Assert.AreEqual("vendingmachine.csv", FileReader.fileName);
        }

    }
}
