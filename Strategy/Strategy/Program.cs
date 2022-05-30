using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            RouteCalculator r = new RouteCalculator();
            r.calculateRoute("Car");
            r.calculateRoute("Walking");
            r.calculateRoute("Bike");
        }
    }
}
