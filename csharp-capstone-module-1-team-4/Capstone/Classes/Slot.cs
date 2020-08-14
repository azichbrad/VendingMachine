using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Slot
    {
        private string slotID;
        public List<InventoryItem> slotItem { get; }
        private decimal itemCost;

        //Creating Constructor for Slot
        public Slot (string slotID, List<InventoryItem> slotItemNumber, decimal itemCost)
        {
            this.slotID = slotID;
            slotItem = slotItemNumber;
            this.itemCost = itemCost;
        }

        public decimal ItemCost
        {
            get
            {
                return itemCost;
            }
        }
        public string SlotID
        {
            get
            {
                return slotID;
            }
        }
                
        public int NumberOfItemsRemaining
        {
            get
            {
                return slotItem.Count;
            }
        }

        public bool IsEmpty
        {
            get 
            {
                return NumberOfItemsRemaining == 0;
            }
        }

        

    }
}
