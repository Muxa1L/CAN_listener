using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Reflection;

namespace CAN_listener
{
    public partial class Form1 : Form
    {
        private SerialPort port;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                portSelector.Items.Add(port);
                Console.WriteLine(port);
            }
            //SerialPort.
            baudRate.Items.Add("2400");
            baudRate.Items.Add("4800");
            baudRate.Items.Add("9600");
            baudRate.Items.Add("19200");
            baudRate.Items.Add("38400");
            baudRate.Items.Add("57600");
            baudRate.Items.Add("115200");
            baudRate.SelectedIndex = 3;
            portSelector.Sorted = true;
            portSelector.Text = portSelector.Items[0].ToString();
            baudRate.Update();
            portSelector.Update();
            
        }

        private void openPortBtn_Click(object sender, EventArgs e)
        {
            if (portSelector.SelectedIndex > -1)
            {
                port = new SerialPort(portSelector.SelectedItem.ToString());
                port.BaudRate = Convert.ToInt16(baudRate.SelectedItem);
                port.Open();
                port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                //object p = port.BaseStream.GetType().GetField("commProp", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(port.BaseStream);
                //Int32 bv = (Int32)p.GetType().GetField("dwSettableBaud", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).GetValue(p);

            }
        }
        private static void DataReceivedHandler(
                        object sender,
                        SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.WriteLine("Data Received:");
            Console.Write(indata);
        }
    }
}
