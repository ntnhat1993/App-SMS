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
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private int _Baudrate;

        public int Baudrate
        {
            get { return _Baudrate; }
            set { _Baudrate = value; }
        }

        private int _DataBits;

        public int DataBits
        {
            get { return _DataBits; }
            set { _DataBits = value; }
        }
        private string _Parity;

        public string Parity
        {
            get { return _Parity; }
            set { _Parity = value; }
        }
        private string _Stopbits;

        public string Stopbits
        {
            get { return _Stopbits; }
            set { _Stopbits = value; }
        }

        private void SettingForm_PreLoad(object sender, EventArgs e)
        {
            cbo_BaudRate.SelectedItem = "9600";
            cbo_DataBit.SelectedItem = "8";
            cbo_Parity.SelectedItem = "None";
            cbo_StopBit.SelectedItem = "One";
        }

        private void CompletedSetting(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_BaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Baudrate = Convert.ToInt32(cbo_BaudRate.Text);
        }

        private void cbo_DataBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            _DataBits = Convert.ToInt32(cbo_DataBit.Text);
        }

        private void cbo_Parity_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Parity = cbo_Parity.Text;
        }

        private void cbo_StopBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Stopbits = cbo_StopBit.Text;
        }
        
    }
}
