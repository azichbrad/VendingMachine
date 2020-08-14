using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public abstract class InventoryItem
    {
        public string itemName;
        public string itemSlot;
        public decimal itemCost;

        public InventoryItem(string itemSlot, string itemName, decimal itemCost)
        {
            this.itemName = itemName;
            this.itemSlot = itemSlot;
            this.itemCost = itemCost;
        }

        public string ItemName
        {
            get
            {
                return itemName;
            }
        }
        public string ItemSlot
        {
            get
            {
                return itemSlot;
            }
        }
        public decimal ItemCost
        {
            get
            {
                return itemCost;
            }
        }
        public string ItemSound;

        public virtual string MakeSound()
        {
        return $"{ItemSound}";
        }

    }
}
