using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stock ibmStock = new Stock("IBM", 100);
            Stock googleStock = new Stock("GOOG", 1000);
            Investor jp = new ConcreteInvestor("Juan Perez");
            Investor mc = new ConcreteInvestor("Maria Cecilia");
            Investor cr = new ConcreteInvestor("Carlos Rodriguez");

            ibmStock.subscribeInvestor(jp);
            ibmStock.subscribeInvestor(mc);

            googleStock.subscribeInvestor(cr);
            googleStock.subscribeInvestor(jp);

            ibmStock.Price = 95;
            googleStock.Price = 1200;

        }


    }
}
