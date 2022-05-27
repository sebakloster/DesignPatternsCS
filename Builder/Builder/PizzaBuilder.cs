using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class PizzaBuilder
    {
        public abstract void cocinarMasa();
        public abstract void agregarQueso();
        public abstract void agregarExtra1(String extra1);
        public abstract void agregarExtra2(String extra2);
        public abstract void agregarExtra3(String extra3);

        public abstract Pizza GetPizza();
    }
}
