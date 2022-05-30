using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{

    public class ConcreteCollection
    {
        List<int> numbers = new List<int>();

        public int this[int index]
        { 
           get { return numbers[index]; }  
            set { numbers.Add(value); } 
        }

        public Iterator createIterator()
        {
            return new IteratorBetween(this);
        }

        public int count()
        {
            return numbers.Count;
        }

    }
}
