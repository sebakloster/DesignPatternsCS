using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ThirdPartyMarketAnalysis thirdPartyMarketAnalysis = new ThirdPartyMarketAnalysis();
            FinancialMarketsApp app = new AdapterXMLtoJSON(thirdPartyMarketAnalysis);
            app.addData("XMLdata1");
            app.addData("XMLdata2");
            app.addData("XMLdata3");
           String analysis = app.analyseMarket(app.XMLmarketData1);
            Console.WriteLine(analysis);
        }
    }
}
