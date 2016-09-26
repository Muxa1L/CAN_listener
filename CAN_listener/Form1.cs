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
using System.Threading;
using System.Collections.Concurrent;

namespace CAN_listener
{
    public partial class Form1 : Form
    {
        private SerialPort port;
        private byte selectedFreq = 2;
        private byte selectedBaudrate;
        private int iter = 0;
        static private ConcurrentDictionary<string, List<string>> history = new ConcurrentDictionary<string, List<string>>();
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
            baudRate.SelectedIndex = 5;
            canFreq.Items.Add("20MHz");
            canFreq.Items.Add("16MHz");
            canFreq.Items.Add("8MHz");
            canFreq.SelectedIndex = 2;
            canSpeed.Items.Add("33Kb");
            canSpeed.Items.Add("125Kb");
            canSpeed.Items.Add("500Kb");
            canSpeed.SelectedIndex = 0;
            portSelector.Sorted = true;
            portSelector.Text = portSelector.Items[0].ToString();
            baudRate.Update();
            portSelector.Update();
            canFreq.Update();
            canSpeed.Update();
            
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
            //string indata = sp.ReadExisting();
            string indata = sp.ReadLine().Trim();
            Console.WriteLine("Data Received:");
            Console.Write(indata);

            string[] data = indata.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string messData = "";
            if (data.Length < 6)
                return;
            for (int i = 6; i < data.Length; i++)
            {
                messData = messData + Convert.ToString(Convert.ToInt32(data[i], 16), 2);
            }
            //if (messData == "")
            //  return;
            messages.Invoke(
                (ThreadStart)delegate ()
                {
                    ListViewItem item = messages.FindItemWithText(data[2]);

                    if (item != null)
                    {
                        if (item.SubItems[3].Text != messData)
                        {
                            List<string> exHist = history.GetOrAdd(data[2], new List<string>());
                            exHist.Add(item.SubItems[3].Text + " : " + DateTime.Now);
                            item.SubItems[3].Text = messData;
                        }
                    }
                    else
                    {
                        ListViewItem newitem = new ListViewItem(new string[] { data[2], data[0], data[4], messData });
                        messages.Invoke(
                            (ThreadStart)delegate ()
                            {
                                messages.Items.Add(newitem);
                            }
                        );

                    }
                }
            );
            
            

            //Standard ID: 0x1E5       DLC: 8  Data: 0x46 0xFF 0xE9 0xC0 0x00 0x00 0x15 0x00
            //Extended ID: 0x10230040  DLC: 8  Data: 0x10 0x01 0x00 0x04 0x10 0x01 0x00 0x04
        }

        private void ConfShield_Click(object sender, EventArgs e)
        {
            string indata = "Standard ID: 0x1E5       DLC: 8  Data: 0x46 0xFF 0xE9 0xC0 0x00 0x00 0x15 0x00";
            string[] data = indata.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string messData = "";

            if (data.Length < 6)
                return;

            for (int i = 6; i < data.Length; i++)
            {
                messData = messData + Convert.ToString(Convert.ToInt32(data[i], 16)+iter, 2);
            }
            iter++;
            ListViewItem item = messages.FindItemWithText(data[2]);

            if (item != null)
            {
                if (item.SubItems[3].Text != messData)
                {
                    item.SubItems[3].Text = messData;
                }
            }
            else
            {
                ListViewItem newitem = new ListViewItem(new string[] { data[2], data[0], data[4], messData });
                messages.Invoke(
                    (ThreadStart)delegate()
                    {
                        messages.Items.Add(newitem);
                    }
                );

            }
            //if (port.IsOpen)
            {
                int configData = (selectedFreq << 4) + selectedBaudrate;
                String test = (configData + " " + decimal.GetBits(configData).ToString());
                //Console.WriteLine( test);
            }
        }

        private void canFreq_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbox = (ComboBox)sender;
            switch (cbox.SelectedIndex)
            {
                case 0:
                    selectedBaudrate = 5;
                    break;
                case 1:
                    selectedBaudrate = 11;
                    break;
                case 2:
                    selectedBaudrate = 14;
                    break;
                default:
                    selectedBaudrate = 5;
                    break;
            }
        }

        private void messages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
