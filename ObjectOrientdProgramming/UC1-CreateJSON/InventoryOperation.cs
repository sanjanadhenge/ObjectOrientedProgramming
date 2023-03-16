using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientdProgramming;

namespace ObjectOrientdProgramming
{
    public class InventoryOperation
    {
        public void ReadJsonFile(String filePath)
        {
            var data = File.ReadAllText(filePath);
            var result = JsonConvert.DeserializeObject<List<InventoryData>>(data);
            foreach(var inventory in result)
            {
                Console.WriteLine(inventory.Name +"\t"+inventory.Weight+"\t"+inventory.PricePerKg+"\t"+inventory.Weight*inventory.PricePerKg);
            }

        }
    }
}