using Capstone.Classes;
using System;

namespace Capstone
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileReader.InventoryImport();
            Menu.MainMenu();
        }
    }
}
