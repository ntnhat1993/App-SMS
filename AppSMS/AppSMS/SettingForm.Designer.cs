namespace AppSMS
{
    partial class SettingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_BaudRate = new System.Windows.Forms.ComboBox();
            this.cbo_DataBit = new System.Windows.Forms.ComboBox();
            this.cbo_Parity = new System.Windows.Forms.ComboBox();
            this.cbo_StopBit = new System.Windows.Forms.ComboBox();
            this.btn_CompletedSetting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BaudRate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DataBit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "StopBit";
            // 
            // cbo_BaudRate
            // 
            this.cbo_BaudRate.FormattingEnabled = true;
            this.cbo_BaudRate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200",
            "123000",
            "256000"});
            this.cbo_BaudRate.Location = new System.Drawing.Point(91, 10);
            this.cbo_BaudRate.Name = "cbo_BaudRate";
            this.cbo_BaudRate.Size = new System.Drawing.Size(121, 21);
            this.cbo_BaudRate.TabIndex = 4;
            this.cbo_BaudRate.SelectedIndexChanged += new System.EventHandler(this.cbo_BaudRate_SelectedIndexChanged);
            // 
            // cbo_DataBit
            // 
            this.cbo_DataBit.FormattingEnabled = true;
            this.cbo_DataBit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbo_DataBit.Location = new System.Drawing.Point(91, 48);
            this.cbo_DataBit.Name = "cbo_DataBit";
            this.cbo_DataBit.Size = new System.Drawing.Size(121, 21);
            this.cbo_DataBit.TabIndex = 5;
            this.cbo_DataBit.SelectedIndexChanged += new System.EventHandler(this.cbo_DataBit_SelectedIndexChanged);
            // 
            // cbo_Parity
            // 
            this.cbo_Parity.FormattingEnabled = true;
            this.cbo_Parity.Items.AddRange(new object[] {
            "Even",
            "Mark",
            "None",
            "Odd",
            "Space"});
            this.cbo_Parity.Location = new System.Drawing.Point(91, 87);
            this.cbo_Parity.Name = "cbo_Parity";
            this.cbo_Parity.Size = new System.Drawing.Size(121, 21);
            this.cbo_Parity.TabIndex = 6;
            this.cbo_Parity.SelectedIndexChanged += new System.EventHandler(this.cbo_Parity_SelectedIndexChanged);
            // 
            // cbo_StopBit
            // 
            this.cbo_StopBit.FormattingEnabled = true;
            this.cbo_StopBit.Items.AddRange(new object[] {
            "None",
            "One",
            "OnePointFive",
            "Two"});
            this.cbo_StopBit.Location = new System.Drawing.Point(91, 129);
            this.cbo_StopBit.Name = "cbo_StopBit";
            this.cbo_StopBit.Size = new System.Drawing.Size(121, 21);
            this.cbo_StopBit.TabIndex = 7;
            this.cbo_StopBit.SelectedIndexChanged += new System.EventHandler(this.cbo_StopBit_SelectedIndexChanged);
            // 
            // btn_CompletedSetting
            // 
            this.btn_CompletedSetting.Location = new System.Drawing.Point(137, 159);
            this.btn_CompletedSetting.Name = "btn_CompletedSetting";
            this.btn_CompletedSetting.Size = new System.Drawing.Size(75, 23);
            this.btn_CompletedSetting.TabIndex = 8;
            this.btn_CompletedSetting.Text = "OK";
            this.btn_CompletedSetting.UseVisualStyleBackColor = true;
            this.btn_CompletedSetting.Click += new System.EventHandler(this.CompletedSetting);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.btn_CompletedSetting);
            this.Controls.Add(this.cbo_StopBit);
            this.Controls.Add(this.cbo_Parity);
            this.Controls.Add(this.cbo_DataBit);
            this.Controls.Add(this.cbo_BaudRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingForm";
            this.Text = "Setting ComPort";
            this.Load += new System.EventHandler(this.SettingForm_PreLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_BaudRate;
        private System.Windows.Forms.ComboBox cbo_DataBit;
        private System.Windows.Forms.ComboBox cbo_Parity;
        private System.Windows.Forms.ComboBox cbo_StopBit;
        private System.Windows.Forms.Button btn_CompletedSetting;
    }
}