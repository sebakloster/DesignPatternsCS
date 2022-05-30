using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public abstract class Beca
    {
        private Alumno alumno;

        public abstract void liquidarCuota();
        public abstract void imprimir();  
        public abstract void checkStateChange();
    }
}
