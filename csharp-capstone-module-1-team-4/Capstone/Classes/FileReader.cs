using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone.Classes
{ 
    public class FileReader
    {
        public static string[] inventoryWords;

        /* Importing initial csv
         * Assign values to inventory
         * Update # inventory
         * Redistribute remaining inventory list */

        //FileAssignment variables
        public static string directoryPath = Environment.CurrentDirectory;
        public static string fileName = "vendingmachine.csv";
        public static string inventoryPath = Path.Combine(directoryPath, fileName);
        
        public static void InventoryImport()
        {
             Slot itemSlot;
            try
            {
                using (StreamReader sr = new StreamReader(inventoryPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] inventoryWords = sr.ReadLine().Split("|");

                        string slotID = inventoryWords[0];
                        string productName = inventoryWords[1];
                        decimal itemPrice = decimal.Parse(inventoryWords[2]);

                        List<InventoryItem> itemsInSlot = new List<InventoryItem>();

                        //If slotID starts with A, the item name, ID and price are added to a list for the type Chips
                        if (slotID.StartsWith("A"))
                        {
                            //Looping through all of those that start with A
                            for (int i = 0; i < 5; i++)
                            {
                                itemsInSlot.Add(new Chips(slotID, productName, itemPrice));
                            }
                            itemSlot = new Slot(slotID, itemsInSlot, itemPrice );
                        }
                        //If slotID starts with B, the item name, ID and price are added to a list for the type Candy
                        else if (slotID.StartsWith("B"))
                        {
                            //Looping through all of those that start with B
                            for (int i = 0; i < 5; i++)
                            {
                                itemsInSlot.Add(new Candy(slotID, productName, itemPrice));
                            }
                            itemSlot = new Slot(slotID, itemsInSlot, itemPrice);
                        }
                        //If slotID starts with C, the item name, ID and price are added to a list for the type Drinks
                        else if (slotID.StartsWith("C"))
                        {
                            //Looping through all of those that start with C
                            for (int i = 0; i < 5; i++)
                            {
                                itemsInSlot.Add(new Drinks(slotID, productName, itemPrice));
                            }
                            itemSlot = new Slot(slotID, itemsInSlot, itemPrice );
                        }
                        //If slotID starts with D, the item name, ID and price are added to a list for the type Gum
                        else
                        {
                            //Looping through all of those that start with D
                            for (int i = 0; i < 5; i++)
                            {
                                itemsInSlot.Add(new Gum(slotID, productName, itemPrice));
                            }
                            itemSlot = new Slot(slotID, itemsInSlot, itemPrice);
                        }
                        VendingMachine.slot[slotID] = itemSlot;
                    }

                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading file or file not found");
            }
            
        }

    }
                   
        


    
}
