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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_rescan = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.sim900serialPort = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btn_rescan
            // 
            this.btn_rescan.Location = new System.Drawing.Point(129, 64);
            this.btn_rescan.Name = "btn_rescan";
            this.btn_rescan.Size = new System.Drawing.Size(75, 23);
            this.btn_rescan.TabIndex = 2;
            this.btn_rescan.Text = "RESCAN";
            this.btn_rescan.UseVisualStyleBackColor = true;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(343, 22);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 3;
            this.btn_connect.Text = "CONNECT";
            this.btn_connect.UseVisualStyleBackColor = true;
            // 
            // btn_setting
            // 
            this.btn_setting.Location = new System.Drawing.Point(236, 64);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(75, 23);
            this.btn_setting.TabIndex = 4;
            this.btn_setting.Text = "SETTING";
            this.btn_setting.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 107);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(405, 142);
            this.textBox1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_rescan);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "SIM900";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_rescan;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_setting;
        private System.IO.Ports.SerialPort sim900serialPort;
        private System.Windows.Forms.TextBox textBox1;
    }
}

