using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Pizza
    {
        private String tipo;
        private String masa;
        private String queso;
        private String extra1;
        private String extra2;
        private String extra3;

        public Pizza(string tipo)
        {
            this.tipo = tipo;
        }

        public string Masa { get => masa; set => masa = value; }
        public string Queso { get => queso; set => queso = value; }
        public string Extra1 { get => extra1; set => extra1 = value; }
        public string Extra2 { get => extra2; set => extra2 = value; }
        public string Extra3 { get => extra3; set => extra3 = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public override string ToString()
        {
            return "Tipo: " + this.tipo + " Masa: " + this.Masa + " Queso: " + this.Queso + " Extra 1: " + this.Extra1 + " Extra 2: " + this.Extra2 + " Extra 3: " + this.Extra3;
        }
    }
}
