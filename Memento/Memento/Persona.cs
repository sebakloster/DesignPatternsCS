using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Persona
    {
        private string name;
        private string lastname;
        private int id;
        private int age;

        public Persona(string name, string lastname, int id, int age)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Id = id;
            this.Age = age;
        }

        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }

        public void setMemento(PersonMemento pm)
        {
           this.Name = pm.getState().Name;
           this.Lastname = pm.getState().Lastname;
           this.Age= pm.getState().Age;
           this.Id = pm.getState().Id;
        }

        public PersonMemento createMemento()
        {
            return new PersonMemento(this.name, this.lastname, this.id, this.age);
        }

        public override string ToString()
        {
            return "Name: " + this.name + " lastname: " +  this.Lastname + " age: " +  this.age + " id: " + this.id;
        }
    }
}
