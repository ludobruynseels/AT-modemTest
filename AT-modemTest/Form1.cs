using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using ScintillaNET;

namespace AT_modemTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static SerialPort MySerialPort { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
                scintilla1.Margins[0].Type = MarginType.Number;
                scintilla1.Margins[0].Width = 16;

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
            var cmd = txtCommand.Text;
            cmd = cmd.Replace("<^Z>", "\u001A");
            MySerialPort.Write($"{cmd}\r");
        }

        private void DataReceivedHandler(
            object sender,
            SerialDataReceivedEventArgs e)
        {
            txtCommand.Invoke(
                new Action(() =>
                {
                    var data= ReadData(sender);
                    scintilla1. InsertText(scintilla1.Text.Length, data);

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

        private void button1_Click(object sender, EventArgs e)
        {
            var s = "\u001a";
            MySerialPort.Write(s);
        }

        private void txtCommand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001a')
            {
               var textbox = (TextBox)sender;
               textbox.Text += "<^Z>";
               e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }


    }
}
