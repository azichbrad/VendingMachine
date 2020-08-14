using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class GumTests
    {
        [TestMethod]
        public void MakeSound()
        {
            Gum gumSound = new Gum("B1", "Big Red", 1.05M);
            Assert.AreEqual("Chew Chew, Yum!", gumSound.MakeSound());
        }
    }
}
