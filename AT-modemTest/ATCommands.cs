using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using AT_modemTest.Commands;
using AT_modemTest.Properties;
using ScintillaNET;

namespace AT_modemTest
{
    public partial class AtCommands : Form, IAtCommands
    {
        private static SerialPort MySerialPort { get; set; }

        public AtCommands()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                scinLog.Margins[0].Type = MarginType.Number;
                scinLog.Margins[0].Width = 16;

                scinScript.Margins[0].Type = MarginType.Number;
                scinScript.Margins[0].Width = 16;

                foreach (var portName in SerialPort.GetPortNames())
                {
                    PortnameToolStripComboBox1.Items.Add(portName);
                }

                PortnameToolStripComboBox1.SelectedItem = Settings.Default.Portname;
            
            BaudrateToolStripComboBox1.Items.AddRange(new object[] {300, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200});
            BaudrateToolStripComboBox1.SelectedItem = Settings.Default.Baudrate;

            MySerialPort = SerialPortFactory();

            MySerialPort.DataReceived += DataReceivedHandler;
            MySerialPort.Open();
        }

        private static SerialPort SerialPortFactory()
        {
            var mySerialPort = new SerialPort();

            if (!string.IsNullOrEmpty(Settings.Default.Portname))
            {
                mySerialPort.PortName = Settings.Default.Portname;
            }
            else
            {
                mySerialPort.PortName = SerialPort.GetPortNames()[0];
            }


            mySerialPort.BaudRate = Settings.Default.Baudrate;
            mySerialPort.Parity = Settings.Default.Parity;
            mySerialPort.DataBits = Settings.Default.Databits;
            mySerialPort.StopBits = Settings.Default.Stopbits;
            mySerialPort.Handshake = Settings.Default.Handshake;

            mySerialPort.ReadTimeout = 500;
            mySerialPort.WriteTimeout = 500;

            return mySerialPort;
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
            Settings.Default.Save();

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

        private void copyCommandToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var control = scinLog;
            var cp = control.CurrentLine;
            txtCommand.Text = control.Lines[cp].Text.Trim('\n');
        }

        private void copyCommandToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var control = scinScript;
            var cp = control.CurrentLine;
            txtCommand.Text = control.Lines[cp].Text.Trim('\n'); 
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

        private void openScriptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ICommand cmd = new OpenScriptCommand(this);
            cmd.Execute();
        }

        private void saveLogToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ICommand cmd = new SaveLogCommand(this);
            cmd.Execute();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void PortnameComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = (ToolStripComboBox) sender;
            var s = (string) cb.SelectedItem;
            Settings.Default.Portname = s;

            if (MySerialPort == null)
            {
                return;
            }

            if (MySerialPort.IsOpen)
            {
                MySerialPort.Close();
            }
            
            MySerialPort.PortName = s;
            try
            {
                MySerialPort.Open();
            }
            catch
            {
                MessageBox.Show($@"Cannot open port {s}", @"Probleempje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BaudrateToolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = (ToolStripComboBox)sender;
            var br = (int) cb.SelectedItem;
            Settings.Default.Baudrate = br;
            if (MySerialPort == null)
            {
                return;
            }

            if (MySerialPort.IsOpen)
            {
                MySerialPort.Close();
            }

            MySerialPort.BaudRate = br;
            try
            {
                MySerialPort.Open();
            }
            catch
            {
                MessageBox.Show($@"Cannot open port {MySerialPort.PortName}", @"Probleempje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
