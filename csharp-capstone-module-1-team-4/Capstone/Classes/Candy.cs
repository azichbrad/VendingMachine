using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Candy : InventoryItem
    {
        
        public Candy (string itemSlot, string itemName, decimal itemCost) : base(itemSlot, itemName, itemCost)
        {
            
        }
        /* Sound
        Item name
        Price 
        Quantity */
        public string itemSound = "Munch Munch";
        public override string MakeSound()
        {
            return $"{itemSound}, Yum!";
        }
    }
}
