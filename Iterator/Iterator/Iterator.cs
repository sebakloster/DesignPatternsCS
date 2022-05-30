using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public abstract class Iterator
    {
        public abstract int getNext();
        public abstract int getCurrent();

    }
}
