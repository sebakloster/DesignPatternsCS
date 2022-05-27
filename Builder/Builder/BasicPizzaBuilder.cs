using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BasicPizzaBuilder : PizzaBuilder
    {
        private Pizza basicPizza = new Pizza("Basic");


        public override void agregarExtra1(string extra1)
        {
            this.basicPizza.Extra1 = extra1;
        }

        public override void agregarExtra2(string extra2)
        {
            this.basicPizza.Extra2 = extra2;
        }

        public override void agregarExtra3(string extra3)
        {
            this.basicPizza.Extra3 = extra3;
        }

        public override void agregarQueso()
        {
            this.basicPizza.Queso = "Queso basico";
        }

        public override void cocinarMasa()
        {
            this.basicPizza.Masa = "Masa basica";

        }

        public override Pizza GetPizza()
        {
            return this.basicPizza;
        }
    }
}
