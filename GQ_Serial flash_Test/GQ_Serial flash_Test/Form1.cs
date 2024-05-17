using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Windows.Input;
using System.Windows;
using System.Text.RegularExpressions;

namespace GQ_Serial_flash_Test
{
    public partial class Form1 : Form
    {

        bool Serial_isopen = false;
        SerialPort serial_port = new SerialPort();
        bool Looprunning = false;
        int macerror = 0;
        string MACADDRESS = "";
        string CHECKMAC = "";

        public Form1()
        {
            InitializeComponent();
            combo_Serialport.Items.Clear();

            foreach (string s in SerialPort.GetPortNames())
            {
                combo_Serialport.Items.Add(s);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Port_Click(object sender, EventArgs e)
        {
            if (Serial_isopen) {
                btn_oneshot.Enabled = false;
                btn_Loop.Enabled = false;
                box_Delay.Enabled = false;
                box_Count.Enabled = false; 
                box_MAC.Enabled = false;

                MessageBox.Show("Port is Closed");
                btn_Port.Text = "OPEN";
                
                if (serial_port.IsOpen) serial_port.Close();

                Serial_isopen = false;
            }
            else
            {
                btn_oneshot.Enabled = true;
                btn_Loop.Enabled = true;
                box_Delay.Enabled = true;
                box_Count.Enabled = true;
                box_MAC.Enabled = true;

                if (!serial_port.IsOpen)
                {
                    serial_port.PortName = combo_Serialport.Text;
                    serial_port.BaudRate = 115200;
                    serial_port.DataBits = 8;
                    serial_port.StopBits = StopBits.One;
                    serial_port.Parity = Parity.None;
                    serial_port.DataReceived += new SerialDataReceivedEventHandler(serial_port_DataReceived);
                }

                try
                {
                    serial_port.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Serial can't open!");
                }

                MessageBox.Show("Port is Open");
                btn_Port.Text = "CLOSE";
                Serial_isopen = true;
            }
        }

        private void serial_port_DataReceived(object sender, SerialDataReceivedEventArgs e){
            this.Invoke(new EventHandler(SerialData_Received));
        }

        private void SerialData_Received(object s, EventArgs e){
            string ReceiveData = serial_port.ReadExisting();
            Serial_Console.AppendText(ReceiveData);

            var match = Regex.Match(ReceiveData, @"GQ: MACAddr\[(?<MacAddress>([0-9a-fA-F]{2}:){5}[0-9a-fA-F]{2})\]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var MatchMac = match.Groups["MacAddress"].Value;

            if (MACADDRESS.Equals(MatchMac)) {
                // 올바른 값이 검출된 경우
            } else {
                MAC_CHECK_FIELD.AppendText("Different MAC found! count : " + macerror + " / " + ReceiveData);
            }
            Serial_Console.ScrollToCaret();
            MAC_CHECK_FIELD.ScrollToCaret();
        }

        private void btn_oneshot_Click(object sender, EventArgs e) 
        {
            serial_port.WriteLine("reset");
            Serial_Console.Clear();
        }

        private void btn_Loop_Click(object sender, EventArgs e)
        {
            if (Looprunning)
            {
                Looprunning = false;
                btn_Loop.Text = "Reset(Loop)";
                MessageBox.Show("Loop Stop");
                remain.Visible = false;
            }
            else
            {
                if (box_Count.ToString().Length == 0 || box_Delay.ToString().Length == 0 || box_MAC.ToString().Length == 0)
                {
                    MessageBox.Show("Input Delay and Count!");
                    MessageBox.Show("DON'T FORGET INPUT MAC ADDRESS!");
                }
                else if (int.Parse(box_Count.Text) < 0 || int.Parse(box_Delay.Text) < 10)
                {
                    MessageBox.Show("SET Delay > 10, Count > 0");
                }
                else
                {
                    int delay = int.Parse(box_Delay.Text);
                    int count = int.Parse(box_Count.Text);
                    remain.Visible = true;
                    remain.Text = "Remain : " + count;
                    btn_Loop.Text = "STOP";
                    Looprunning = true;
                    macerror = 0;
                    MACADDRESS = box_MAC.Text;
                    CHECKMAC = "GQ: MACAddr[" + MACADDRESS + "]";

                    MAC_CHECK_FIELD.Clear();
                    Serial_Console.Clear();

                    while (macerror <= count)
                    {
                        if (Looprunning)
                        {
                            Delay(delay * 1000);

                            serial_port.WriteLine("reset");
                            
                            remain.Text = "Remain : " + (count - macerror);
                            macerror++;
                        }
                        else break;
                    }
                    remain.Visible = false;
                    Looprunning = false;
                    MessageBox.Show(combo_Serialport.Text + "'s Test is Done");
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Serial_Console.Clear();
        }

        public void Delay(int ms)
        {
            DateTime dateTimeNow = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, ms);
            DateTime dateTimeAdd = dateTimeNow.Add(duration);
            while (dateTimeAdd >= dateTimeNow)
            {
                System.Windows.Forms.Application.DoEvents();
                dateTimeNow = DateTime.Now;
            }
            return;
        }
    }
}
