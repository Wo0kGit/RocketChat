
namespace RocketServer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.IstClientIP = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "SRV :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(78, 22);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(371, 23);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "127.0.0.1:9000";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(365, 377);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(84, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(78, 51);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(371, 291);
            this.txtInfo.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(78, 348);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(371, 23);
            this.txtMessage.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(284, 377);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "MSG :";
            // 
            // IstClientIP
            // 
            this.IstClientIP.FormattingEnabled = true;
            this.IstClientIP.ItemHeight = 15;
            this.IstClientIP.Location = new System.Drawing.Point(464, 51);
            this.IstClientIP.Name = "IstClientIP";
            this.IstClientIP.Size = new System.Drawing.Size(252, 349);
            this.IstClientIP.TabIndex = 7;
            this.IstClientIP.SelectedIndexChanged += new System.EventHandler(this.IstClientIP_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "https://github.com/Wo0kGit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 23);
            this.linkLabel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Select IP to send :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 426);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IstClientIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RocketChat - Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox IstClientIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
    }
}

