using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PizzaShop pizzaShop = new PizzaShop();
            Pizza p1 = pizzaShop.crearPizza("Normal");
            Pizza p2 = pizzaShop.crearPizza("Basic");
            Pizza p3 = pizzaShop.crearPizza("Premium");

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p3.ToString());

        }

    }
}
