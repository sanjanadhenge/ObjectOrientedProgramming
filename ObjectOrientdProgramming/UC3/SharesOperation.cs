using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientdProgramming.UC3
{
    public class SharesOperation
    {
        public void ReadJsonFile(String filepath)
        {
            double sum = 0;
            var data = File.ReadAllText(filepath);
            var result = JsonConvert.DeserializeObject<List<SharesData>>(data);
            foreach (var Shares in result)
            {
                sum += (Shares.NumOFShares * Shares.SharePrice);
                Console.WriteLine(Shares.Name + "\t" + Shares.NumOFShares + "\t" + Shares.SharePrice + "\t"+Shares.NumOFShares*Shares.SharePrice);
            }
            Console.WriteLine("Total Stock Value :" + sum);
        }
    }
}
