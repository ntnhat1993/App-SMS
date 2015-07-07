namespace AppSMS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.COMLabel = new System.Windows.Forms.Label();
            this.cbo_ComPorts = new System.Windows.Forms.ComboBox();
            this.btn_rescan = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.sim900serialPort = new System.IO.Ports.SerialPort(this.components);
            this.msgListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // COMLabel
            // 
            this.COMLabel.AutoSize = true;
            this.COMLabel.Location = new System.Drawing.Point(27, 27);
            this.COMLabel.Name = "COMLabel";
            this.COMLabel.Size = new System.Drawing.Size(61, 13);
            this.COMLabel.TabIndex = 0;
            this.COMLabel.Text = "COMPORT";
            // 
            // cbo_ComPorts
            // 
            this.cbo_ComPorts.FormattingEnabled = true;
            this.cbo_ComPorts.Location = new System.Drawing.Point(129, 24);
            this.cbo_ComPorts.Name = "cbo_ComPorts";
            this.cbo_ComPorts.Size = new System.Drawing.Size(182, 21);
            this.cbo_ComPorts.TabIndex = 1;
            // 
            // btn_rescan
            // 
            this.btn_rescan.Location = new System.Drawing.Point(129, 64);
            this.btn_rescan.Name = "btn_rescan";
            this.btn_rescan.Size = new System.Drawing.Size(75, 23);
            this.btn_rescan.TabIndex = 2;
            this.btn_rescan.Text = "RESCAN";
            this.btn_rescan.UseVisualStyleBackColor = true;
            this.btn_rescan.Click += new System.EventHandler(this.rescan_ComPort);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(343, 22);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(87, 23);
            this.btn_connect.TabIndex = 3;
            this.btn_connect.Text = "CONNECT";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.connect_ComPort);
            // 
            // btn_setting
            // 
            this.btn_setting.Location = new System.Drawing.Point(236, 64);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(75, 23);
            this.btn_setting.TabIndex = 4;
            this.btn_setting.Text = "SETTING";
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.setting_ComPort);
            // 
            // sim900serialPort
            // 
            this.sim900serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.receivedData_ComPort);
            // 
            // msgListBox
            // 
            this.msgListBox.FormattingEnabled = true;
            this.msgListBox.Location = new System.Drawing.Point(30, 100);
            this.msgListBox.Name = "msgListBox";
            this.msgListBox.ScrollAlwaysVisible = true;
            this.msgListBox.Size = new System.Drawing.Size(400, 225);
            this.msgListBox.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 344);
            this.Controls.Add(this.msgListBox);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_rescan);
            this.Controls.Add(this.cbo_ComPorts);
            this.Controls.Add(this.COMLabel);
            this.Name = "MainForm";
            this.Text = "SIM900";
            this.Load += new System.EventHandler(this.MainForm_PreLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label COMLabel;
        private System.Windows.Forms.ComboBox cbo_ComPorts;
        private System.Windows.Forms.Button btn_rescan;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_setting;
        private System.IO.Ports.SerialPort sim900serialPort;
        private System.Windows.Forms.ListBox msgListBox;
    }
}

