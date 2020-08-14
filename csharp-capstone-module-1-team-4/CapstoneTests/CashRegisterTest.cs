using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    [TestClass]
    public class CashRegisterTest
    {
        [TestMethod]
        public void MoneyAccepted()
        {
            decimal balance = 10M;
            CashRegister.AddToBalance(10M);
            Assert.AreEqual(10M, CashRegister.balance);
            CashRegister.balance = 0M;

            balance = 5M;
            CashRegister.AddToBalance(5M);
            Assert.AreEqual(5M, CashRegister.balance);
            CashRegister.balance = 0M;

            balance = 2M;
            CashRegister.AddToBalance(2M);
            Assert.AreEqual(2M, CashRegister.balance);
            CashRegister.balance = 0M;

            balance = 1M;
            CashRegister.AddToBalance(1M);
            Assert.AreEqual(1M, CashRegister.balance);
            CashRegister.balance = 0M;
        }
        [TestMethod]
        public void MoneySpent()
        {
            decimal cost = 3.05M;
            CashRegister.balance = 5M;
            CashRegister.SubtractFromBalance(cost);
            Assert.AreEqual(1.95M, CashRegister.balance);

            cost = 1M;
            CashRegister.balance = 10M;
            CashRegister.SubtractFromBalance(cost);
            Assert.AreEqual(9M, CashRegister.balance);

            cost = 5;
            CashRegister.balance = 5M;
            CashRegister.SubtractFromBalance(cost);
            Assert.AreEqual(0M, CashRegister.balance);

            cost = 1.5M;
            CashRegister.balance = 40M;
            CashRegister.SubtractFromBalance(cost);
            Assert.AreEqual(38.5M, CashRegister.balance);
        }

        [TestMethod]
        public void ChangeCalculatorEndingBalance()
        {
            decimal balance = 0;
            CashRegister.ChangeWithLeastAmountOfCoins();

            Assert.AreEqual(0M, CashRegister.balance);

            balance = 10M;
            CashRegister.ChangeWithLeastAmountOfCoins();
            Assert.AreEqual(0M, CashRegister.balance);

            balance = 1500M;
            CashRegister.ChangeWithLeastAmountOfCoins();
            Assert.AreEqual(0M, CashRegister.balance);

        }
        [TestMethod]
        public void CorrectSelection()
        {
            decimal balance = 1;
            CashRegister.ShouldAddToBalance(1);
            Assert.AreEqual(1M, CashRegister.addMoney);

            balance = 2;
            CashRegister.ShouldAddToBalance(2);
            Assert.AreEqual(2M, CashRegister.addMoney);

            balance = 5;
            CashRegister.ShouldAddToBalance(3);
            Assert.AreEqual(5M, CashRegister.addMoney);

            balance = 10;
            CashRegister.ShouldAddToBalance(4);
            Assert.AreEqual(10M, CashRegister.addMoney);
        }

    }
    
}
