using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class PersonMemento
    {
        private string name;
        private string lastname;
        private int id;
        private int age;

        public PersonMemento(string name, string lastname, int id, int age)
        {
            this.name = name;
            this.lastname = lastname;
            this.id = id;
            this.age = age;
        }

        public string Name { get => name; }
        public string Lastname { get => lastname; }
        public int Id { get => id; }
        public int Age { get => age; }

        public PersonMemento getState()
        {
            return this;
        }
    }
}
