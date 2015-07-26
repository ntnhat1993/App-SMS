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
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_ComPorts = new System.Windows.Forms.ComboBox();
            this.btn_rescan = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.sim900serialPort = new System.IO.Ports.SerialPort(this.components);
            this.messageBox = new System.Windows.Forms.TextBox();
            this.messageGridView = new System.Windows.Forms.DataGridView();
            this.btn_ReadMessage = new System.Windows.Forms.Button();
            this.btn_DeleteMesage = new System.Windows.Forms.Button();
            this.btn_DeleteAllMessage = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.messageGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMPORT";
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
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(13, 107);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageBox.Size = new System.Drawing.Size(588, 78);
            this.messageBox.TabIndex = 5;
            // 
            // messageGridView
            // 
            this.messageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messageGridView.Location = new System.Drawing.Point(13, 191);
            this.messageGridView.Name = "messageGridView";
            this.messageGridView.Size = new System.Drawing.Size(497, 228);
            this.messageGridView.TabIndex = 6;
            this.messageGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.messageGridView_CellClick);
            // 
            // btn_ReadMessage
            // 
            this.btn_ReadMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ReadMessage.Location = new System.Drawing.Point(516, 191);
            this.btn_ReadMessage.Name = "btn_ReadMessage";
            this.btn_ReadMessage.Size = new System.Drawing.Size(87, 23);
            this.btn_ReadMessage.TabIndex = 7;
            this.btn_ReadMessage.Text = "READ FULL";
            this.btn_ReadMessage.UseVisualStyleBackColor = true;
            this.btn_ReadMessage.Click += new System.EventHandler(this.btn_ReadMessage_Click);
            // 
            // btn_DeleteMesage
            // 
            this.btn_DeleteMesage.Location = new System.Drawing.Point(516, 367);
            this.btn_DeleteMesage.Name = "btn_DeleteMesage";
            this.btn_DeleteMesage.Size = new System.Drawing.Size(87, 23);
            this.btn_DeleteMesage.TabIndex = 8;
            this.btn_DeleteMesage.Text = "DELETE";
            this.btn_DeleteMesage.UseVisualStyleBackColor = true;
            this.btn_DeleteMesage.Click += new System.EventHandler(this.btn_DeleteMesage_Click);
            // 
            // btn_DeleteAllMessage
            // 
            this.btn_DeleteAllMessage.Location = new System.Drawing.Point(516, 396);
            this.btn_DeleteAllMessage.Name = "btn_DeleteAllMessage";
            this.btn_DeleteAllMessage.Size = new System.Drawing.Size(87, 23);
            this.btn_DeleteAllMessage.TabIndex = 9;
            this.btn_DeleteAllMessage.Text = "DELETE ALL";
            this.btn_DeleteAllMessage.UseVisualStyleBackColor = true;
            this.btn_DeleteAllMessage.Click += new System.EventHandler(this.btn_DeleteAllMessage_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 431);
            this.Controls.Add(this.btn_DeleteAllMessage);
            this.Controls.Add(this.btn_DeleteMesage);
            this.Controls.Add(this.btn_ReadMessage);
            this.Controls.Add(this.messageGridView);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_rescan);
            this.Controls.Add(this.cbo_ComPorts);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "SIM900";
            this.Load += new System.EventHandler(this.MainForm_PreLoad);
            ((System.ComponentModel.ISupportInitialize)(this.messageGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort sim900serialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_ComPorts;
        private System.Windows.Forms.Button btn_rescan;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.DataGridView messageGridView;
        private System.Windows.Forms.Button btn_ReadMessage;
        private System.Windows.Forms.Button btn_DeleteMesage;
        private System.Windows.Forms.Button btn_DeleteAllMessage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

