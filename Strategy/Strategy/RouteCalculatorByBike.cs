using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class RouteCalculatorByBike : RouteCalculatorStrategy
    {
        public override void calculateRoute()
        {
            Console.WriteLine("Route calculated for bikes");
        }
    }
}
