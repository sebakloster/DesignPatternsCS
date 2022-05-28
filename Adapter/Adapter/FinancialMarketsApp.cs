using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public abstract class FinancialMarketsApp
    {
        private List<String> XMLmarketData = new List<string>();

        public List<string> XMLmarketData1 { get => XMLmarketData; set => XMLmarketData = value; }

        public void addData(string data)
        {
            this.XMLmarketData1.Add(data);
        }
        public abstract string analyseMarket(List<String> XMLmarketData);
    }
}
