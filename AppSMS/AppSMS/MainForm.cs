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
using System.Data.SqlServerCe;

namespace AppSMS
{
    public partial class MainForm : Form
    {
        private Sim900Controller sim900 = new Sim900Controller();

        private DataAccess dbSim900 = new DataAccess();

        public MainForm()
        {
            InitializeComponent();
            InitSystem();
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

        private void ClearGridView()
        {
            while (messageGridView.Rows[0].DataGridView.RowCount > 1)
            {
                messageGridView.Rows.Remove(messageGridView.Rows[0]);
            }
        }

        private void UpdateMessage()
        {
            if (sim900serialPort.IsOpen)
            {
                StopCheckNewMessage();
                ClearBufferSerial();
                sim900serialPort.Write(sim900.sim900ReadSMSCmd);
                WaitResponse();
            }
        }

        private void InitSystem()
        {
            dbSim900.AddDataToGrid(messageGridView);

            DataGridViewColumn state = messageGridView.Columns[0];
            DataGridViewColumn date = messageGridView.Columns[1];
            DataGridViewColumn phoneNumber = messageGridView.Columns[2];
            DataGridViewColumn content = messageGridView.Columns[3];
            state.Width = 70;
            date.Width = 130;
            phoneNumber.Width = 100;
            content.Width = 150;
        }

        /*private void addDataToGrid()
        {
            SqlCeConnection conn = new SqlCeConnection(
                Properties.Settings.Default.SIM900ConnectionString);
            conn.Open();

            using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(
                "SELECT * FROM MessageTable", conn))
            {
                DataSet dataSource = new DataSet();

                adapter.Fill(dataSource, "Message_table");
                conn.Close();
                messageGridView.DataSource = dataSource;
                messageGridView.DataMember = "Message_table";
            }
        }*/

        private void WaitResponse()
        {
            timer1.Start();
        }

        private void StopWaitResponse()
        {
            timer1.Stop();
        }

        private void CheckNewMessage()
        {
            timer2.Start();
        }

        private void StopCheckNewMessage()
        {
            timer2.Stop();
        }

        private void ClearBufferSerial()
        {
            sim900serialPort.ReadExisting();
        }

        private void messageGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Message selectedMsg = new Message();

            selectedMsg.state = messageGridView.Rows[messageGridView.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            selectedMsg.date = messageGridView.Rows[messageGridView.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
            selectedMsg.phoneNumber = messageGridView.Rows[messageGridView.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
            selectedMsg.content = messageGridView.Rows[messageGridView.SelectedCells[0].RowIndex].Cells[3].Value.ToString();
            messageBox.Text = "Time: " + selectedMsg.date + Environment.NewLine + 
                                "Phone Number: " + selectedMsg.phoneNumber + Environment.NewLine + 
                                   selectedMsg.content;

            if (selectedMsg.state.IndexOf("UNREAD") >= 0)
            {
                dbSim900.ChangeStateMsg(selectedMsg);
                dbSim900.AddDataToGrid(messageGridView);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)       //timer 3s
        {
            StopWaitResponse();
            if (sim900serialPort.IsOpen)
            {
                if (sim900serialPort.BytesToRead > 0)
                {
                    string listOfMsg = sim900serialPort.ReadExisting();
                    sim900.ReadSMS(listOfMsg);
                    dbSim900.InsertData(sim900.msg);
                    dbSim900.AddDataToGrid(messageGridView);
                    sim900serialPort.WriteLine(sim900.sim900DelSMSCmd);
                }
            }
            CheckNewMessage();
        }

        private int i;
        private void test()
        {
            if (i++ % 2 == 0)
            {
                btn_setting.Enabled = false;
            }
            else
            {
                btn_setting.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)    //timer 2s: polling check new message
        {
            if (sim900serialPort.IsOpen)
            {
                if (sim900serialPort.BytesToRead > 0)
                {
                    string responseFromSIM900 = sim900serialPort.ReadExisting();
                    
                    if (sim900.IsIncomingCall(responseFromSIM900) == true)
                    {
                        sim900serialPort.WriteLine(sim900.sim900HangUpSMSCmd);
                    }
                    else if (sim900.IsNewMessage(responseFromSIM900) == true)
                    {
                        UpdateMessage();
                    }
                }
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
                    UpdateMessage();
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
                StopCheckNewMessage();
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
            try
            {
                sim900serialPort.DataReceived += new SerialDataReceivedEventHandler(receivedData_ComPort);
            }
            catch
            {
                MessageBox.Show(this, "Out Of memory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_PreLoad(object sender, EventArgs e)
        {
            getComPort();
        }

        private void btn_ReadMessage_Click(object sender, EventArgs e)
        {
            dbSim900.AddDataToGrid(messageGridView);
        }

        private void btn_DeleteMesage_Click(object sender, EventArgs e)
        {
            Message selectedMsg = new Message();

            selectedMsg.state = messageGridView.Rows[messageGridView.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            selectedMsg.date = messageGridView.Rows[messageGridView.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
            selectedMsg.phoneNumber = messageGridView.Rows[messageGridView.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
            selectedMsg.content = messageGridView.Rows[messageGridView.SelectedCells[0].RowIndex].Cells[3].Value.ToString();

            dbSim900.DeleteData(selectedMsg);
            dbSim900.AddDataToGrid(messageGridView);
        }

        private void btn_DeleteAllMessage_Click(object sender, EventArgs e)
        {
            ClearGridView();
        }

    }
}
