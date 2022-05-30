using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Alumno
    {
        private string nombreCompleto;
        private int promedio;
        private double cuota;

        Beca beca;

        public Alumno(string nombreCompleto, int promedio, double cuota)
        {
            this.NombreCompleto = nombreCompleto;
            this.Promedio = promedio;
            this.cuota = cuota;
        }

        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public int Promedio { get => promedio; set => promedio = value; }
        public double Cuota { get => cuota; set => cuota = value; }
        public Beca Beca { get => beca; set => beca = value; }

        public void liquidarCuota()
        {
            beca.liquidarCuota();
        }
    }
}
