using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ThirdPartyMarketAnalysis
    {
        public String analyseMarkets(List<String> marketData)
        {
            String analyzed = "";
            foreach (String market in marketData)
            {
                analyzed += market + " analyzed - ";
            }
            return analyzed;
        }
    }
}
