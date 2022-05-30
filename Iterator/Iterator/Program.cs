using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConcreteCollection c = new ConcreteCollection();
            c[0] = 0;
            c[1] = 1;
            c[2] = 2;
            c[3] = 3;
            c[4] = 4;
            c[5] = 5;
            c[6] = 6;
            c[7] = 7;
            Iterator i = c.createIterator();

            int aux = 0;
            while(aux != -1)
            {
                aux = i.getNext();
                Console.WriteLine(aux); 
            }
        }
    }
}
