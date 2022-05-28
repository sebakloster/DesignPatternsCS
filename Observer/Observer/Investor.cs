using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class Investor
    {
        private String fullName;


        public string FullName { get => fullName; set => fullName = value; }

        public abstract void update(double price);
    }
}
