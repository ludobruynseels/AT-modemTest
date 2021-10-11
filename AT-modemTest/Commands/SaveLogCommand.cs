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
            var dialog = new OpenFileDialog() {DefaultExt = "atl", InitialDirectory = "c:\\", Filter = "atl files (*.atl)|*.atl|All files (*.*)|*.*", 
                FilterIndex = 2, RestoreDirectory = true , CheckFileExists = false};
            var result = dialog.ShowDialog();
            if (result != DialogResult.OK) 
            {
                return;
            }
            using var file = new System.IO.StreamWriter(dialog.FileName, false);
            var message = Form.ScControl.Text;
            file.Write(message);
        }
        }
}