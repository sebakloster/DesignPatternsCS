using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Command
{
    public class CopyButton
    {
        private Command command;

        public void setCommand(Command command)
        {
            this.command = command;
        }
        public void executeCommand()
        {
            this.command.execute();
        }
    }
}
