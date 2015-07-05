using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            getComPort();
        }

        private void getComPort()
        {
            btn_connect.Enabled = true; 

            string[] ports = System.IO.Ports.SerialPort.GetPortNames();

            cbo_ComPorts.Items.Clear();           

            foreach (string port in ports)
            {
                cbo_ComPorts.Items.Add(port);                

            }

            btn_connect.Enabled = true;            
        }
    }
}
