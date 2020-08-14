using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class CashRegister
    {
        public static decimal balance;
        public static decimal previousBalance;
        public static decimal addMoney;

        public static decimal ShouldAddToBalance(decimal moneySelectValue)
        {
            
            if (moneySelectValue == 1)
            {
                addMoney = 1M;
            }
            else if (moneySelectValue == 2)
            {
                addMoney = 2M;
            }
            else if (moneySelectValue == 3)
            {
                addMoney = 5M;
            }
            else if (moneySelectValue == 4)
            {
                addMoney = 10M;
            }

            return addMoney;
        }
        public static void AddToBalance (decimal addMoney)
        {
            balance += addMoney;
        }

        public static void SubtractFromBalance (decimal spendMoney)
        {
            balance -= spendMoney;
        }
        public static void ChangeWithLeastAmountOfCoins()
        {
            //counts each coin denomination
            int quarterCounter = 0;
            int dimeCounter = 0;
            int nickelCounter = 0;
            previousBalance = balance;
            Console.WriteLine("Calculating your change...");
            //as long as there is left over money in the balance, calculate the change
            while (balance > 0M)
            {
                if (balance >= 0.25M)
                {
                    balance = balance - 0.25M;
                    quarterCounter++;
                }
                else if (balance >= 0.1M)
                {
                    balance = balance - 0.1M;
                    dimeCounter++;
                }
                else if (balance >= 0.05M)
                {
                    balance = balance - 0.05M;
                    nickelCounter++;
                }
            }
            Console.WriteLine($"Your change is {quarterCounter} quarters, {dimeCounter} dimes, and {nickelCounter} nickels for a total of {previousBalance:C2}");
            AuditLog.createAuditEntry("GIVE CHANGE", previousBalance, balance );
        }
    }
}
