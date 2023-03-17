using Newtonsoft.Json;
using ObjectOrientdProgramming.UC1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientdProgramming.UC3
{
    public class StockOpeartion
    {
        public void ReadJsonFile(string filePath)
        {
            var data = File.ReadAllText(filePath);
            var result = JsonConvert.DeserializeObject<List<StockData>>(data);
            double sum = 0;
            foreach (var stock in result)
            {
                sum += (stock.NumOfShares * stock.SharePrice);
                Console.WriteLine(stock.Name + "\t" + stock.NumOfShares + "\t" + stock.SharePrice + "\t" + stock.NumOfShares * stock.SharePrice);
            }
            Console.WriteLine("Total Stock Value :"+sum);
        }
    }
}
