using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class SubMenu
    {
      /*  public static void MainMenu()
        {
           // private VendingMachine vendingMachine = new VendingMachine();

        public void DisplayMenu()
            while (true)
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
                    FileReader.InventoryImport();
                    foreach (KeyValuePair<string, Slot> kvp in VendingMachine.slot)
                    {
                        Console.WriteLine();
                        Console.Write($"{kvp.Key} : {kvp.Value.slotItem[0].ItemName} : Price {kvp.Value.slotItem[0].ItemCost:C2} : Stock {kvp.Value.NumberOfItemsRemaining}");
                    }
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
        }*/
    }
}
