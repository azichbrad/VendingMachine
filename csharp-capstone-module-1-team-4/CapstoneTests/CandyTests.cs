using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class CandyTests
    {
        [TestMethod]
        public void MakeSound()
        {
            Candy candySound = new Candy("B1", "ChocolateFudge", 1.05M);
            Assert.AreEqual("Munch Munch, Yum!", candySound.MakeSound() );
        }
    }
}
