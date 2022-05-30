using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Command
{
    public class Copy
    {
        public void execute(string text)
        {
            Console.WriteLine("Copied: " + text);
        }
    }
}
