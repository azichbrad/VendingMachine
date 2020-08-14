using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Chips : InventoryItem
    {
        public Chips(string itemSlot, string itemName, decimal itemCost) : base(itemSlot, itemName, itemCost)
        {

        }

        public string itemSound = "Crunch Crunch";
        public override string MakeSound()
        {
            return $"{itemSound}, Yum!";
        }
    }
}
