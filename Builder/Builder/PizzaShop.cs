using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PizzaShop
    {
        private PizzaBuilder builder;

        public PizzaShop()
        {
        }

        public PizzaBuilder Builder { get => builder; set => builder = value; }

        public Pizza crearPizza(String tipo)
        {
            switch (tipo)
            {
                case "Normal":
                    this.builder = new NormalPizzaBuilder();
                    this.builder.cocinarMasa();
                    this.builder.agregarQueso();
                    this.builder.agregarExtra1("normal extra");
                    this.builder.agregarExtra2("normal extra2");
                    return this.builder.GetPizza();
                case "Basic":
                    this.builder = new NormalPizzaBuilder();
                    this.builder.cocinarMasa();
                    this.builder.agregarQueso();
                    this.builder.agregarExtra1("basic extra");
                    return this.builder.GetPizza();
                case "Premium":
                    this.builder = new NormalPizzaBuilder();
                    this.builder.cocinarMasa();
                    this.builder.agregarQueso();
                    this.builder.agregarExtra1("Premium extra");
                    this.builder.agregarExtra2("Premium extra2");
                    this.builder.agregarExtra3("Premium extra3");
                    return this.builder.GetPizza();
                    default:
                    throw new ArgumentOutOfRangeException(nameof(tipo));
            }

        }

    }
}
