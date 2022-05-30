using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Persona p = new Persona("Seba", "Kloster", 01, 22);
            PersonCareTaker pct = new PersonCareTaker();
            pct.Pm = p.createMemento();
            p.Name = "New fake name";
            Console.WriteLine(p.ToString());
            Console.WriteLine("Restoring...");
            p.setMemento(pct.Pm);
            Console.WriteLine(p.ToString());
        }
    }
}
