
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Command
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Copy copyReceiver = new Copy();
            Paste pasteReceiver = new Paste();
            CopyCommand copyCommand = new CopyCommand(copyReceiver, "sampleText");
            PasteCommand pasteCommand = new PasteCommand(pasteReceiver, "sampleText");

            CopyButton copyButton = new CopyButton();
            copyButton.setCommand(copyCommand);
            CopyShortcut copyShortcut = new CopyShortcut();
            copyShortcut.setCommand(copyCommand);
            PasteButton pasteButton = new PasteButton();
            pasteButton.setCommand(pasteCommand);
            PasteShortcut pasteShortcut = new PasteShortcut();
            pasteShortcut.setCommand(pasteCommand);

            copyButton.executeCommand();
            pasteButton.executeCommand();
            copyShortcut.executeCommand();
            pasteShortcut.executeCommand();


        }
    }
}
