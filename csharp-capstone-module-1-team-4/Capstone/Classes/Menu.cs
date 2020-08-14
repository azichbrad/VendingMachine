using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone.Classes
{
    public class Menu
    {
        //private Dictionary<string, Slot> slot = new Dictionary<string, Slot>();
        /*prompt
         * display items
         * purchase items
         * Exit
         * Buttons
         * */

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("---- Welcome to the Vendo-Matic 800 ----");
            Console.WriteLine("Please select a number 1 - 3 for the following menu options.");
            Console.WriteLine();
            Console.WriteLine("(1) Display Vending Machine Items");
            Console.WriteLine("(2) Purchase");
            Console.WriteLine("(3) Exit");
            string startingMenuSelect = Console.ReadLine();

            if (startingMenuSelect == "1")
            {
                Console.Clear();
                //display VendingMachine dictionary.ItemName and List.Amount
                //FileReader.InventoryImport();
                VendingMachine.DisplayItems(VendingMachine.slot);
                //foreach (KeyValuePair<string, Slot> kvp in VendingMachine.slot)
                //{
                //    Console.WriteLine();
                //    Console.Write($"{kvp.Key} : {kvp.Value.slotItem[0].ItemName} : Price {kvp.Value.slotItem[0].ItemCost:C2} : Stock {kvp.Value.NumberOfItemsRemaining}");
                //}
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press Enter key to return to Main Menu");
                Console.ReadLine();
                MainMenu();
                
            }
            else if (startingMenuSelect == "2")
            {
                
                PurchaseMenu();
            }
            else if (startingMenuSelect == "3")
            {
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Not a valid menu selection. Restarting...");
                MainMenu();
            }

        }

        public static void PurchaseMenu()
        {
            Console.Clear();
            Console.WriteLine("---- Purchasing Menu ----");
            Console.WriteLine("Please select a number 1 - 3 for the following menu options.");
            Console.WriteLine($"Current balance: {CashRegister.balance:C2}");
            Console.WriteLine();
            Console.WriteLine("(1) Feed Money");
            Console.WriteLine("(2) Select Product");
            Console.WriteLine("(3) Finish Transaction");
            string purchaseMenuSelect = Console.ReadLine();

            if (purchaseMenuSelect == "1")
            {
                Menu.TakeMoneyMenu();
                // unsure if we want to ask amounts here or elsewhere, if so will do another method to encompass that
            }
            else if (purchaseMenuSelect == "2")
            {
                VendingMachine.VendingSelection();
                // Show list of products available and Customer Enters a code to select. 
                //if code doesnt exist return info and back to PurchaseMenu()
                //if sold out, informed then returned to PurchaseMenu()
                //if valid product selected it is dispensed:


                        
            }
            else if (purchaseMenuSelect == "3")
            {
                CashRegister.ChangeWithLeastAmountOfCoins();
                AuditLog.UpdateAuditLog(VendingMachine.newAuditEntries);
                Console.ReadKey();
                //Customer finalizes all transactions and is returned to the MainMenu()
                //return change - using fewest coins using division and modulus probably
                //Machine current balance should be udpated to 0$ remaining
                //salesLog updated here or in option 2
                
            MainMenu();
            }
            else
            {
                Console.WriteLine("Not a valid menu selection");
                PurchaseMenu();
            }
        }
        public static void TakeMoneyMenu()
        {
            Console.WriteLine("-------This vending machine only accepts whole dollar amounts: $1, $2, $5, $10-------");
            Console.WriteLine();
            Console.WriteLine("Please select your amount:");
            Console.WriteLine("1) $1");
            Console.WriteLine("2) $2");
            Console.WriteLine("3) $5");
            Console.WriteLine("4) $10");

            Console.WriteLine();

            int moneySelectValue = 0;
            int.TryParse(Console.ReadLine(), out moneySelectValue);
            decimal addMoney = 0M;
            if (moneySelectValue > 0 && moneySelectValue <=4)
            {
                addMoney = CashRegister.ShouldAddToBalance(moneySelectValue);
                
                AuditLog.createAuditEntry("FEED MONEY", CashRegister.previousBalance, CashRegister.balance );
                CashRegister.AddToBalance(addMoney);
            }
            else
            {
                Console.WriteLine("Invalid selection.");
                TakeMoneyMenu();
            }
            PurchaseMenu();
        }

    }
}
