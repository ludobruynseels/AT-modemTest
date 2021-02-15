using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using AT_modemTest.Commands;
using ScintillaNET;

namespace AT_modemTest
{
    public partial class AtCommands : Form, IAtCommands
    {
        public AtCommands()
        {
            InitializeComponent();
        }

        private static SerialPort MySerialPort { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
                scinLog.Margins[0].Type = MarginType.Number;
                scinLog.Margins[0].Width = 16;

                scinScript.Margins[0].Type = MarginType.Number;
                scinScript.Margins[0].Width = 16;

            // Create a new SerialPort object with default settings.
            MySerialPort = new SerialPort
            {
                PortName = "COM10",
                BaudRate = 19200,
                Parity = Parity.None,
                DataBits = 8,
                StopBits = StopBits.One,
                Handshake = Handshake.None,
                ReadTimeout = 500,
                WriteTimeout = 500
            };

            MySerialPort.DataReceived += DataReceivedHandler;
            MySerialPort.Open();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            var cmdText = txtCommand.Text;
            if (cmdText.StartsWith("CLR"))
            {
               ICommand cmd = new ClearLogCommand(this);
               cmd.Execute();
            }

            cmdText = cmdText.Replace("<^Z>", "\u001A");
            MySerialPort.Write($"{cmdText}\r");
        }

        public Scintilla ScLogControl => scinLog;
        public Scintilla ScScriptControl => scinScript;

        public void ClearLog()
        {
                scinLog.ClearAll();
                txtCommand.Text = string.Empty;
        }

        public void SendlineToModem(string s)
        {
            txtCommand.Text = s;
            BtnSend_Click(txtCommand, null);
        }

        private void DataReceivedHandler(
            object sender,
            SerialDataReceivedEventArgs e)
        {
            txtCommand.Invoke(
                new Action(() =>
                {
                    var data= ReadData(sender);
                    scinLog.InsertText(scinLog.Text.Length, data);
                    scinLog.ScrollRange(scinLog.TextLength, scinLog.TextLength);
                    txtCommand.Text = string.Empty;
                }));
        }

        static string ReadData(object sender)
        {
            var sp = (SerialPort)sender;
            return sp.ReadExisting();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MySerialPort.Close();
            Thread.Sleep(500);
        }

        private void txtCommand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001a')
            {
               var textbox = (TextBox)sender;
               textbox.Text += @"<^Z>";
               e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void saveLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICommand cmd = new SaveLogCommand(this);
            cmd.Execute();
        }

        private void openScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICommand cmd = new OpenScriptCommand(this);
            cmd.Execute();
        }

        private void runScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICommand cmd = new RunScriptCommand(this);
            cmd.Execute();
        }

        private void copyCommandToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var control = scinLog;
            var cp = control.CurrentLine;
            txtCommand.Text = control.Lines[cp].Text;

        }

        private void copyCommandToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var control = scinScript;
            var cp = control.CurrentLine;
            txtCommand.Text = control.Lines[cp].Text;
        }

        private void clearWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearLog();
        }

        private void runScriptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ICommand cmd = new RunScriptCommand(this);
            cmd.Execute();
        }
    }
}
