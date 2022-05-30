using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class IteratorBetween : Iterator
    {
        private ConcreteCollection collection;
        int current = 0;
        int step = 1;   

        public IteratorBetween(ConcreteCollection c)
        {
            collection = c;
        }

        public override int getCurrent()
        {
            return this.collection[current];
        }

        public override int getNext()
        {
            current= current + step;
            int aux = 0;
            if(current< collection.count())
            {
                aux = this.collection[current];
                current++;
                return aux;
            }
            else
            {
                return -1;
            }
            
        }
    }
}
