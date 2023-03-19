using Newtonsoft.Json;
using ObjectOrientdProgramming.UC3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientdProgramming.UC4
{
    public class StockAccount
    {
        List<StockData> amazon;
        List<StockData> tCS;
        List<StockData> reliance;
        StockData stockData = new StockData();
        public void ReadJsonFile(string filePath)
        {
            var data = File.ReadAllText(filePath);
            var result = JsonConvert.DeserializeObject<StockList>(data);
            amazon = result.Amazon;
            tCS = result.TCS;
            reliance = result.Reliance;
        }
        public void Display(List<StockData>list)
        {
            foreach (var stock in list)
            {
                Console.WriteLine(stock.Name + "\t" + stock.NumOfShares + "\t" + stock.SharePrice + "\t" +" \t" + stock.SharePrice);
            }
        }
        public void Buy(double amount ,String Symbol)
        {
            StockData stockData = new StockData();
            Console.WriteLine("Enter the no of Stock you want to Buy");
            int A = Convert.ToInt32(Console.ReadLine());

            if (Symbol.Equals("Amaz"))
            {
                foreach (var item in amazon)
                {
                    item.NumOfShares = item.NumOfShares - A;
                    amount = amount - (A*item.SharePrice);
                }
                Display(amazon);
               
            }

            if (Symbol.Equals("Xyz"))
            {
                foreach (var item in tCS)
                {
                    item.NumOfShares = amount + item.NumOfShares;
                }
            }


        }
       
    }
}
