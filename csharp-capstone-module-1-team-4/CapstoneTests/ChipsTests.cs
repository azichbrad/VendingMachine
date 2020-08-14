using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class ChipsTests
    {
        [TestMethod]
        public void MakeSound()
        {
            Chips chipsSound = new Chips("B1", "Pringles", 1.05M);
            Assert.AreEqual("Crunch Crunch, Yum!", chipsSound.MakeSound());
        }
    }
}
