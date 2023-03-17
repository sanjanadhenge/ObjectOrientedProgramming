using ObjectOrientdProgramming.UC1;
using ObjectOrientdProgramming.UC2;
using ObjectOrientdProgramming.UC3;
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
            
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Option\n1.Inventory Operation\n2.Inventory Data Mangement\n3.Stock Operation\n4.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InventoryOperation inventoryOperation = new InventoryOperation();
                        inventoryOperation.ReadJsonFile(@"C:\Users\SOURABH\Desktop\Day 3\ObjectOrientedProgramming\ObjectOrientdProgramming\UC1\Invetntory.json");
                        break;
                    case 2:
                        InventoryDataMangement inventoryDataMangement = new InventoryDataMangement();
                        bool flag1 = true;
                        while (flag1)
                        {
                            Console.WriteLine("Select Option\n1.Read JSON File\n2.Add Inventory Data\n3.Edit Data\n4.Delete Data\n5.Exit");
                            int option1 = Convert.ToInt32(Console.ReadLine());
                            switch (option1)
                            {
                                case 1:
                                    inventoryDataMangement.ReadJsonFile(@"C:\Users\SOURABH\Desktop\Day 3\ObjectOrientedProgramming\ObjectOrientdProgramming\UC2\inventoryDetails.json");
                                    break;
                                case 2:
                                    inventoryDataMangement.AddInventory();
                                    break;
                                case 3:
                                    inventoryDataMangement.EditData();
                                    break;
                                case 4:
                                    inventoryDataMangement.DeleteData();
                                    break;
                                case 5:
                                    flag1 = false;
                                    break;
                            }
                        }
                        break;
                    case 3:
                        SharesOperation sharesOperation = new SharesOperation();
                        sharesOperation.ReadJsonFile(@"C:\Users\SOURABH\Desktop\Day 3\ObjectOrientedProgramming\ObjectOrientdProgramming\UC3\StockAccount.json");
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }

        }
    }
}
