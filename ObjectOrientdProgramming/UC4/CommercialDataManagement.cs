using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ObjectOrientdProgramming.UC1;
using ObjectOrientdProgramming.UC3;

namespace ObjectOrientdProgramming.UC4
{ 
    internal class CommercialDataManagement
    {
        
       List<StockData> CompanyList;
       List<StockData> stocks;
      StockData stockData = new StockData();
        int amount = 5000;
        public void ReadStockFile(String StockFilePath)
        { 
            var data = File.ReadAllText(StockFilePath);
            var result = JsonConvert.DeserializeObject<List<StockData>>(data);
            CompanyList = result;
            Display(result);
        }
        public void ReadCustmerFile (String UserFilePath)
        {
            var data = File.ReadAllText(UserFilePath);
            var result = JsonConvert.DeserializeObject<List<StockData>>(data);
            stocks= result;
            Display(result );
        }
        public void ValueOf()
        {
            double sum = 0;
            foreach (var item in stocks)
            {
                sum += (item.NumOfShares * item.SharePrice);

            }
            Console.WriteLine("Total Value of Account Dollars :" + sum);
          }
        public void Display(List<StockData> list)
        {
            foreach (var stock in list)
            {
                Console.WriteLine(stock.Name + "\t" + stock.NumOfShares + "\t" + stock.SharePrice );
            }
        }

        public void BuyShares()
        {
            //StockData stockData = new StockData();
            Console.WriteLine("Enter Name of the Company to buy share");
            String name = Console.ReadLine();
            foreach(var data in stocks)
            {
                if(data.Name.Equals(name))
                {
                    stockData = data;
                }
            }
            if(stockData == null)
            {
                Console.WriteLine(name+" "+"with Stocks Not available");
            }
            else
            {
                Console.WriteLine("Enter No ofshares need to buy");
                int shares = Convert.ToInt32(Console.ReadLine());
                foreach(var  stock in stocks)
                {
                    if(shares<= stock.NumOfShares)
                    {
                        if(amount >= shares*stock.SharePrice)
                        {
                            foreach(var data in CompanyList)
                            {
                                if(data.Name == name)
                                {
                                    stockData = data;
                                }
                            }
                            if(stockData == null)
                            {
                                CompanyList.Add(stock);
                            }
                            else
                            {
                                foreach(var data in CompanyList)
                                {
                                    if(data.Name.Equals(name))
                                    {
                                        data.NumOfShares += shares/2.0;
                                     
                                    }
                                   
                                }
                            
                            }
                            foreach(var data in stocks)
                            {
                                if (data.Name.Equals(name))
                                {
                                    data.NumOfShares -= shares / 2.0;

                                }
                            }
                        }
                    }
                }
                Console.WriteLine("Stock Account Details\n");
                //Display(stocks);
                SaveFileStock(stocks);
            }
            Console.WriteLine("Companies Details\n");
           // Display(CompanyList);
            SaveFileUser(CompanyList);
        }
        public void SellShares()
        {
          
            Console.WriteLine("Enter Name of the Company to Sell shares");
            String name = Console.ReadLine();
            foreach (var data in stocks)
            {
                if (data.Name.Equals(name))
                {
                    stockData = data;
                }
            }
            if (stockData == null)
            {
                Console.WriteLine(name + " " + "with Stocks Not available");
            }
            else
            {
                Console.WriteLine("Enter No ofshares need to Sell");
                int shares = Convert.ToInt32(Console.ReadLine());
                foreach (var stock in stocks)
                {
                    if (shares <= stock.NumOfShares)
                    {
                        if (amount >= shares * stock.SharePrice)
                        {
                            foreach (var data in CompanyList)
                            {
                                if (data.Name == name)
                                {
                                    stockData = data;
                                }
                            }
                            if (stockData == null)
                            {
                                CompanyList.Add(stock);
                            }
                            else
                            {
                                foreach (var data in CompanyList)
                                {
                                    if (data.Name.Equals(name))
                                    {
                                        data.NumOfShares -= shares / 2.0;                       
                                    }
                                    
                                }

                            }
                            foreach (var data in stocks)
                            {
                                if (data.Name.Equals(name))
                                {
                                    data.NumOfShares += shares / 2.0;
                                   
                                }
                               
                            }
                        }
                    }
                }
                Console.WriteLine("Stock Account Details\n");
                SaveFileStock(stocks);
               // Display(stocks);

            }
            Console.WriteLine("Companies Details\n");
           // Display(CompanyList);
            SaveFileUser(CompanyList);
        
            }
        public void SaveFileUser(List<StockData> list)
        {
            String Str = JsonConvert.SerializeObject(list);
            File.WriteAllText(@"C:\Users\SOURABH\Desktop\Day 3\ObjectOrientedProgramming\ObjectOrientdProgramming\UC3\StockDeatails.json", Str);
            ReadStockFile(@"C:\Users\SOURABH\Desktop\Day 3\ObjectOrientedProgramming\ObjectOrientdProgramming\UC3\StockDeatails.json");
        }
        public void SaveFileStock(List<StockData> list)
        {
            String Str = JsonConvert.SerializeObject(list);
            File.WriteAllText(@"C:\Users\SOURABH\Desktop\Day 3\ObjectOrientedProgramming\ObjectOrientdProgramming\UC4\user.json", Str);
            ReadCustmerFile(@"C:\Users\SOURABH\Desktop\Day 3\ObjectOrientedProgramming\ObjectOrientdProgramming\UC4\user.json");
        }
    }
}
