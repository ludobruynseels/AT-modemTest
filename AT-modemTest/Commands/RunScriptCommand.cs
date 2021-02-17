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
                
                if (s.Length == 0)
                {
                    continue;
                }

                if (s.StartsWith("//"))
                {
                    continue;
                }

                if (Form.ModemStatus == Status.Error)
                {
                    return;
                }
                
                if (s.ToUpper() == "WAIT")
                {
                    Thread.Sleep(2000);
                    continue;
                }

                Form.SendlineToModem(s);
                Application.DoEvents();
                
                while (Form.ModemStatus == Status.Running)
                {
                    Thread.Sleep(250);
                    Application.DoEvents();
                }
            }
        }
    }
}