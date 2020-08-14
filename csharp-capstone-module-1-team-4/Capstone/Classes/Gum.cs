using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Gum : InventoryItem
    {
        public Gum(string itemSlot, string itemName, decimal itemCost) : base(itemSlot, itemName,  itemCost)
        {

        }

        public string itemSound = "Chew Chew";
        public override string MakeSound()
        {
            return $"{itemSound}, Yum!";
        }
    }
}
