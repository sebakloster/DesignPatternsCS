using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class NormalPizzaBuilder : PizzaBuilder
    {
        private Pizza basicPizza = new Pizza("Normal");


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
            this.basicPizza.Queso = "Queso normal";
        }

        public override void cocinarMasa()
        {
            this.basicPizza.Masa = "Masa normal";

        }

        public override Pizza GetPizza()
        {
            return this.basicPizza;
        }
    }
}
