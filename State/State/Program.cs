using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Alumno a = new Alumno("Sebastian Kloster", 7, 10000);
            a.Beca = new Beca1(a);
            a.liquidarCuota();
            a.Promedio = 8;
            a.liquidarCuota();
            a.Promedio = 10;
            a.liquidarCuota();
            a.Promedio = 6;
            a.liquidarCuota();
        }
    }
}
