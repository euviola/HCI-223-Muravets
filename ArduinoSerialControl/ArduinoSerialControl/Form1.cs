using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoSerialControl
{
    public partial class Form1 : Form
    {
        private SerialPort arduinoPort;

        public Form1()
        {
            InitializeComponent();
            
            arduinoPort = new SerialPort("COM3", 9600);  
            arduinoPort.DataReceived += new SerialDataReceivedEventHandler(ArduinoPort_DataReceived);

            try
            {
                arduinoPort.Open();
                txtOutput.AppendText("Connected to Arduino\n");
            }
            catch (Exception ex)
            {
                txtOutput.AppendText("Error: Could not connect to Arduino. " + ex.Message + "\n");
            }
        }

        private void btnLEDOn_Click(object sender, EventArgs e)
        {
            if (arduinoPort.IsOpen)
            {
                arduinoPort.WriteLine("LED_ON");
                txtOutput.AppendText("Sent: LED_ON\n");
            }
            else
            {
                txtOutput.AppendText("Error: Serial port is closed.\n");
            }
        }
        

        private void btnLEDOff_Click_1(object sender, EventArgs e)
        {
            if (arduinoPort.IsOpen)
            {
                arduinoPort.WriteLine("LED_OFF");
                txtOutput.AppendText("Sent: LED_OFF\n");
            }
            else
            {
                txtOutput.AppendText("Error: Serial port is closed.\n");
            }
        }

        private void ArduinoPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // This will be executed when data is received from Arduino
            string data = arduinoPort.ReadLine();
            Invoke(new Action(() => txtOutput.AppendText("Received: " + data + "\n")));
        }
    }
}
