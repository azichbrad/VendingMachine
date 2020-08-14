using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests
{
    [TestClass]
    public class DrinksTests
    {
        [TestMethod]
        public void MakeSound()
        {
            Drinks drinkSound = new Drinks("B1", "OrangeJuice", 1.05M);
            Assert.AreEqual("Glug Glug, Yum!", drinkSound.MakeSound());
        }
    }
}
