using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ConcreteInvestor : Investor
    {
        public ConcreteInvestor(string fullname)
        {
            this.FullName = fullname;
        }

        public override void update(double price)
        {
            Console.WriteLine(this.FullName + " has been informed that the new price is: " + price);
        }
    }
}
