using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;
using System.Linq;

namespace Capstone.Classes
{
    public class VendingMachine
    {
        public static Dictionary<string, Slot> slot = new Dictionary<string, Slot>();
        public static List<string> newAuditEntries = new List<string>();
        //public static Dictionary<string, int> newSalesReportEntries = new Dictionary<string, int>();
        public static string itemSelection = "";
        public static decimal itemCost;

        //Ran out of time for SalesLog
        //public void InitializeSalesReport()
        //{
        //    foreach (KeyValuePair<string, Slot> kvp in slot)
        //    {
        //        string key = kvp.Value.SlotType.ItemName;
        //        newSalesReportEntries[key] = 0;
        //    }
        //}

        public static void VendingSelection()
        {
            Console.Clear();
            Console.WriteLine("Please make your selection");
            Console.WriteLine("Please enter a letter and number to select the item you want.");
            Console.WriteLine("Example: A2");
            Console.WriteLine();
            Console.WriteLine($"Current Balance: {CashRegister.balance:C2}");
            Console.WriteLine();

            DisplayItems(slot);

            Console.WriteLine();
            Console.WriteLine();
            itemSelection = Console.ReadLine().ToUpper();
            CompareInput(itemSelection);

        }

        public static void CompareInput(string slotID)
        {
            if (slot.ContainsKey(slotID))
            {
                if (ItemLeft(slotID))
                {
                    Console.WriteLine("Item is sold out. Returning to Purchase Menu. Press any key to continue.");
                    Console.ReadLine();
                    Menu.PurchaseMenu();
                }
                else if (SufficientBalance(slotID))
                {
                    Console.WriteLine("Insufficient funds. Please deposit more. Returning to Purchase Menu.");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadLine();
                    Menu.PurchaseMenu();
                }
                else
                {
                    VendingItem(slotID);
                }
            }
            else if (!slot.ContainsKey(slotID))
            {
                Console.WriteLine("Invalid Selection. Press any key to return to the Purchase Menu.");
                Console.ReadKey();
                Menu.PurchaseMenu();
            }

        }

        public static void VendingItem(string slotID)
        {
            Console.WriteLine("Vending item...");
            CashRegister.previousBalance = CashRegister.balance;
            CashRegister.SubtractFromBalance(slot[slotID].slotItem[0].ItemCost);
            Console.WriteLine($"Item: {slot[slotID].slotItem[0].ItemName} Cost: {slot[slotID].slotItem[0].ItemCost:C2} Current Balance: {CashRegister.balance:C2}");

            Console.WriteLine(slot[slotID].slotItem[0].MakeSound());
            AuditLog.createAuditEntry(($"{slotID} {slot[slotID].slotItem[0].ItemName}"), CashRegister.balance, CashRegister.previousBalance);
            slot[slotID].slotItem.RemoveAt(0);
            Console.WriteLine();
            Console.WriteLine("Press any key to return to the Purchasing Menu.");
            Console.ReadKey();
            Menu.PurchaseMenu();

        }

        public static bool ItemLeft(string slotID)
        {
            return slot[slotID].IsEmpty;
        }

        public static bool SufficientBalance(string slotID)
        {
            return CashRegister.balance < slot[slotID].ItemCost;
        }

        public static void DisplayItems(Dictionary <string,Slot> slot)
        {
            foreach (KeyValuePair<string, Slot> kvp in VendingMachine.slot)
            {

                Console.WriteLine();
                Console.Write($"{kvp.Key} : ");

                if (kvp.Value.slotItem.Count > 0)
                {
                    Console.Write($"{kvp.Value.slotItem[0].ItemName} : Price {kvp.Value.slotItem[0].ItemCost:C2} : Stock {kvp.Value.slotItem.Count}");
                }
                else
                {
                    Console.Write($"SOLD OUT");
                }
            }
        }

    }
}
