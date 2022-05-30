using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Command
{
    public class CopyCommand : Command
    {
        private Copy copyReceiver;
        private string textParam;

        public CopyCommand(Copy copyReceiver, string text)
        {
            this.copyReceiver = copyReceiver;
            this.textParam = text;
        }

        public override void execute()
        {
            this.copyReceiver.execute(textParam + " by " + this.GetType().Name);
        }
    }
}
