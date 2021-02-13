using System;
using System.Windows.Forms;

namespace AT_modemTest.Commands
{
    internal class OpenScriptCommand : ICommand
    {
        public OpenScriptCommand(IAtCommands form)
        {
            Form = form;
        }

        public IAtCommands Form { get; }
        public void Execute()
        {
            var path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var dialog = new OpenFileDialog()
            {
                DefaultExt = "atl",
                InitialDirectory = path,
                Filter = @"at script files (*.ats)|*.ats|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,
                CheckFileExists = false
            };
            var result = dialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            using var file = new System.IO.StreamReader(dialog.FileName, false);
            var message = Form.ScLogControl.Text;
            while (!file.EndOfStream) 
            {
             var s =   file.ReadLine();
             Form.ScScriptControl.InsertText(Form.ScScriptControl.Text.Length, s + '\n');
            }
        }
    }
}
