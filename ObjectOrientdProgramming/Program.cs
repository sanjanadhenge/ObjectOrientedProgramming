using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientdProgramming
{
    public class Program
    {
       static void Main(string[] args)
        {
            InventoryOperation inventoryOperation = new InventoryOperation();
            inventoryOperation.ReadJsonFile(@"C:\Users\SOURABH\Desktop\Day 3\ObjectOrientedProgramming\ObjectOrientdProgramming\UC1-CreateJSON\Inventory.json");
        }
    }
}
