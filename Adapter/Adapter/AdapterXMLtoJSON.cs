using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AdapterXMLtoJSON : FinancialMarketsApp
    {
        private ThirdPartyMarketAnalysis adaptee;

        public AdapterXMLtoJSON(ThirdPartyMarketAnalysis adaptee)
        {
            this.adaptee = adaptee;
        }



        public override string analyseMarket(List<String> XMLmarketData)
        {
            List<String> JSONmarketData = new List<string>();

            foreach(String market in XMLmarketData)
            {
                JSONmarketData.Add( market + " JSON ");
            }

           String res = adaptee.analyseMarkets(JSONmarketData);
            return res;
        }
    }
}
