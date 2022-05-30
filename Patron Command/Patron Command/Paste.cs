using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Command
{
    public class Paste
    {
        public void execute(string text)
        {
            Console.WriteLine("Pasted: " + text);
        }
    }
}
