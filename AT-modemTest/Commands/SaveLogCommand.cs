using System;
using System.Windows.Forms;

namespace AT_modemTest.Commands
{
    internal class SaveLogCommand : ICommand
    {
        public SaveLogCommand(IAtCommands atCommands)
        {
            Form = atCommands;
        }

        public IAtCommands Form { get; }

        public void Execute()
        {
            var path =  Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var dialog = new SaveFileDialog() {DefaultExt = "atl", InitialDirectory = path, Filter = @"at log files (*.atl)|*.atl|All files (*.*)|*.*", 
                FilterIndex = 1, RestoreDirectory = true , CheckFileExists = false};
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