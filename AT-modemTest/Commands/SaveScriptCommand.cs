using System;
using System.Windows.Forms;

namespace AT_modemTest.Commands
{
    internal class SaveScriptCommand : ICommand
    {
        public SaveScriptCommand(IAtCommands atCommands)
        {
            Form = atCommands;
        }

        public IAtCommands Form { get; }

        public void Execute()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var dialog = new SaveFileDialog()
            {
                DefaultExt = "ats",
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
            using var file = new System.IO.StreamWriter(dialog.FileName, false);
            var message = Form.ScLogControl.Text;
            file.Write(message);
        }
    }
}