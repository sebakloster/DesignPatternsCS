using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class RouteCalculator
    {
        private RouteCalculatorStrategy RouteCalculatorStrategy;


        public void calculateRoute(string transport)
        {
            switch (transport)
            {
                case "Walking":
                    this.RouteCalculatorStrategy = new RouteCalculatorByWalking();
                    RouteCalculatorStrategy.calculateRoute();
                    break;
                case "Car":
                    this.RouteCalculatorStrategy = new RouteCalculatorByCar();
                    RouteCalculatorStrategy.calculateRoute();
                    break;
                case "Bike":
                    this.RouteCalculatorStrategy = new RouteCalculatorByBike();
                    RouteCalculatorStrategy.calculateRoute();
                    break;
            }
        }
    }
}
