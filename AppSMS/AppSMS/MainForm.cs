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

namespace AppSMS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();            
        }

        private void getComPort()
        {            
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();

            cbo_ComPorts.Items.Clear();           

            foreach (string port in ports)
            {
                cbo_ComPorts.Items.Add(port);                
            }                     
        }

        private void connect_ComPort(object sender, EventArgs e)
        {
            if (btn_connect.Text == "CONNECT")
            {
                if (sim900serialPort.IsOpen) sim900serialPort.Close();
                if (cbo_ComPorts.Text == "") return;

                sim900serialPort.PortName = cbo_ComPorts.Text;
                try
                {
                    sim900serialPort.Open();
                    btn_rescan.Enabled = false;
                    btn_connect.Text = "DISCONNECT";
                    btn_setting.Enabled = false;
                    cbo_ComPorts.Enabled = false;                                       
                }
                catch
                {
                    MessageBox.Show(this, "Cannot connect ComPort!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (sim900serialPort.IsOpen) sim900serialPort.Close();

                btn_rescan.Enabled = true;
                btn_connect.Text = "CONNECT";
                btn_setting.Enabled = true;
                cbo_ComPorts.Enabled = true;
            }
        }

        private void setting_ComPort(object sender, EventArgs e)
        {
            SettingForm mSettingForm = new SettingForm();
            mSettingForm.ShowDialog();

            sim900serialPort.BaudRate = mSettingForm.Baudrate;

            sim900serialPort.DataBits = mSettingForm.DataBits;
          
            if (mSettingForm.Stopbits == StopBits.None.ToString())
                sim900serialPort.StopBits = StopBits.None;
            else if (mSettingForm.Stopbits == StopBits.One.ToString())
                sim900serialPort.StopBits = StopBits.One;
            else if (mSettingForm.Stopbits == StopBits.OnePointFive.ToString())
                sim900serialPort.StopBits = StopBits.OnePointFive;
            else
                sim900serialPort.StopBits = StopBits.Two;

            if (mSettingForm.Parity == Parity.Even.ToString())
                sim900serialPort.Parity = Parity.Even;
            else if (mSettingForm.Parity == Parity.Mark.ToString())
                sim900serialPort.Parity = Parity.Mark;
            else if (mSettingForm.Parity == Parity.None.ToString())
                sim900serialPort.Parity = Parity.None;
            else if (mSettingForm.Parity == Parity.Odd.ToString())
                sim900serialPort.Parity = Parity.Odd;
            else
                sim900serialPort.Parity = Parity.Space;
        }

        private void rescan_ComPort(object sender, EventArgs e)
        {
            getComPort();
            cbo_ComPorts.Text = "";
        }

        private void receivedData_ComPort(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            updateMessage();
        }

        private void MainForm_PreLoad(object sender, EventArgs e)
        {
            getComPort();
        }

        private void updateMessage()
        {
            DateTime daytime = DateTime.Now;
            String dtn = daytime.ToShortTimeString();
            try
            {
                messageBox.AppendText("[" + dtn + "] " + "Received: " + sim900serialPort.ReadExisting() + "\n");
            }
            catch (Exception ex)
            {
            }
        }

        private void updateMessage2()
        {
        }
    }
}
