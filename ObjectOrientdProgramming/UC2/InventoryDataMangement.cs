using Newtonsoft.Json;
using ObjectOrientdProgramming.UC1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientdProgramming.UC2
{
    public class InventoryDataMangement
    { 
        List<InventoryData> riceList;
        List<InventoryData> wheatList;
        List<InventoryData> pulsesList;

        public void ReadJsonFile(String filepath)
        {
            var data = File.ReadAllText(filepath);
            var result = JsonConvert.DeserializeObject<InventoryList>(data);
            riceList = result.RiceList;
            Display(riceList);
            wheatList = result.WheatList;
            Display(wheatList);
            pulsesList = result.PulsesList;
            Display(pulsesList);


        }
        public void Display(List<InventoryData> list)
        {
            foreach (var inventory in list)
            {
                Console.WriteLine(inventory.Name + "\t" + inventory.Weight + "\t" + inventory.PricePerKg + "\t" + inventory.Weight * inventory.PricePerKg);
            }
        }
        public void AddInventory()
        {
            Console.WriteLine("Enter in Which List New inventory need to be added");
            String name = Console.ReadLine();
            Console.WriteLine("Enter Inventory Data");
            InventoryData data = new InventoryData();
            data.Name = Console.ReadLine();
            data.Weight = Convert.ToDouble(Console.ReadLine());
            data.PricePerKg = Convert.ToDouble(Console.ReadLine());
            if (name.ToLower().Equals("rice"))
            {
                riceList.Add(data);
                Display(riceList);
            }
            if (name.ToLower().Equals("wheat"))
            {
                wheatList.Add(data);
                Display(wheatList);
            }
            if (name.ToLower().Equals("pulses"))
            {
                pulsesList.Add(data);
                Display(pulsesList);
            }
        }
        public void EditData()
        {
            Console.WriteLine("Enter in Which List You want to edit the data");
            String name = Console.ReadLine();
           // InventoryList inventoryList = new InventoryList();
            if (name.ToLower().Equals("rice"))
            {
                foreach (var item in riceList)
                {
                    Console.WriteLine("Enter Name of RICE");
                    item.Name = Console.ReadLine();
                    Console.WriteLine("Enter Weight");
                    item.Weight = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Price Per Kag");
                    item.PricePerKg = Convert.ToDouble(Console.ReadLine());
                    
                }
                Display(riceList);
            }
            if (name.ToLower().Equals("wheat"))
            {
                foreach (var item in wheatList)
                {
                    item.Name = Console.ReadLine();
                    item.Weight = Convert.ToDouble(Console.ReadLine());
                    item.PricePerKg = Convert.ToDouble(Console.ReadLine());
                }
                Display(wheatList);
            }
            if (name.ToLower().Equals("pulses"))
            {
                foreach (var item in pulsesList)
                {
                    item.Name = Console.ReadLine();
                    item.Weight = Convert.ToDouble(Console.ReadLine());
                    item.PricePerKg = Convert.ToDouble(Console.ReadLine());
                }
                Display(pulsesList);
            }
        }
        public void DeleteData()
        {
            InventoryData data = new InventoryData();
            Console.WriteLine("Enter in Which List You want to delete data");
            String name = Console.ReadLine();
            if (name.ToLower().Equals("rice"))
               
            {
                foreach (var item in riceList)
                { 
                 data = item;
                }
                riceList.Remove(data);
                Display(riceList);
            }
            if (name.ToLower().Equals("wheat"))
            {
                foreach (var item in wheatList)
                {
                    data = item;
                }
                wheatList.Remove(data);
                Display(wheatList);
            }
            if (name.ToLower().Equals("pulses"))

            {
                foreach (var item in pulsesList)
                {
                    data = item;
                }
                pulsesList.Remove(data);
                Display(pulsesList);
            }
            
        }
    }
}
