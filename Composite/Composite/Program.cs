using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Program
    {

        public static void Main(string[] args)
        {
            CajaComposite rootBox = new CajaComposite();
            Producto p1 = new Producto(5);
            Producto p2 = new Producto(10);
            CajaComposite innerBox = new CajaComposite();
            Producto p3 = new Producto(15);
            innerBox.Add(p3);
            rootBox.Add(p1);
            rootBox.Add(p2);
            rootBox.Add(innerBox);

            double total = rootBox.calcularTotal();
            Console.WriteLine("El total es: " + total);

        }
    }
}
