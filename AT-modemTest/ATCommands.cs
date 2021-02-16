﻿using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using AT_modemTest.Commands;
using ScintillaNET;

namespace AT_modemTest
{
    public partial class AtCommands : Form, IAtCommands
    {
        private string Portname { get;  set; } = "COM10";
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
                    toolStripComboBox1.Items.Add(portName);
                }

                toolStripComboBox1.SelectedItem = "COM10";

            // Create a new SerialPort object with default settings.
            MySerialPort = new SerialPort
            {
                PortName = Portname,
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

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = (ToolStripComboBox) sender;
            var s = cb.SelectedItem;
            Portname = (string) s;

            if (MySerialPort == null)
            {
                return;
            }

            if (MySerialPort.IsOpen)
            {
                MySerialPort.Close();
            }
            
            MySerialPort.PortName = (string) s;
            try
            {
                MySerialPort.Open();
            }
            catch
            {
                MessageBox.Show($@"Cannot open port {s}", @"Probleempje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
