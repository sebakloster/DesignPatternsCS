using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Command
{
    public class PasteCommand : Command
    {
        private Paste pasteReceiver;
        private string textParam;

        public PasteCommand(Paste pasteReceiver, string text)
        {
            this.pasteReceiver = pasteReceiver;
            this.textParam = text;
        }

        public override void execute()
        {
            this.pasteReceiver.execute(textParam + " by " + this.GetType().Name);
        }
    }
}
