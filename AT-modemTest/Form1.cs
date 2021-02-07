using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

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
            string cmd = txtCommand.Text;
            MySerialPort.Write($"{cmd}\r");
        }

        private void DataReceivedHandler(
            object sender,
            SerialDataReceivedEventArgs e)
        {
            txtCommand.Invoke(
                new Action(() =>
                {
                    txtLog.Text += ReadData(sender);
                    txtCommand.Text = String.Empty;
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
    }
}
