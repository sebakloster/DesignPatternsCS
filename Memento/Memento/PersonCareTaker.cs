using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class PersonCareTaker
    {
        private PersonMemento pm;
        public PersonMemento Pm { get => pm; set => pm = value; }
    }
}
