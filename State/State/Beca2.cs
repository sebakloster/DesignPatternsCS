using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Beca2 : Beca
    {
        private double discount = 0.1;

        private Alumno alumno;

        public Beca2(Alumno alumno)
        {
            this.alumno = alumno;
        }
        public override void liquidarCuota()
        {
            checkStateChange();
            this.alumno.Beca.imprimir();
        }


        public override void imprimir()
        {
            Console.WriteLine("El total a pagar es: " + (this.alumno.Cuota * (1.0-discount)).ToString() + " " + this.GetType().Name);
        }

        public override void checkStateChange()
        {
            if (this.alumno.Promedio <= 7)
            {
                this.alumno.Beca = new Beca2(this.alumno);
            }
            else if (this.alumno.Promedio >= 9)
            {
                this.alumno.Beca = new Beca3(this.alumno);
            }
        }
    }
}
