using System;
using System.Net.Mime;
using System.Threading;
using System.Windows.Forms;

namespace AT_modemTest.Commands
{
    internal class RunScriptCommand : ICommand
    {
        public RunScriptCommand(IAtCommands atCommand)
        {
            Form = atCommand;
        }

        public IAtCommands Form { get; }
        public void Execute()
        {
            foreach (var line in Form.ScScriptControl.Lines)
            {
                var s = line.Text.Trim('\n');
                Form.SendlineToModem(s);
                Thread.Sleep(1500);
                Application.DoEvents();
            }
        }
    }
}