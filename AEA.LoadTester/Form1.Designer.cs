namespace AEA.LoadTester
{
    partial class Form1
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
            this.siteALog = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.siteBLog = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.warningLbl1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSiteABytesSent = new System.Windows.Forms.Label();
            this.lblSiteABytesReceived = new System.Windows.Forms.Label();
            this.lblSiteATimeTaken = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSiteBTimeTaken = new System.Windows.Forms.Label();
            this.lblSiteBBytesReceived = new System.Windows.Forms.Label();
            this.lblSiteBBytesSent = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblResultTimeTaken = new System.Windows.Forms.Label();
            this.lblResultBytesReceived = new System.Windows.Forms.Label();
            this.lblResultBytesSent = new System.Windows.Forms.Label();
            this.lblResultWinner = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // siteALog
            // 
            this.siteALog.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteALog.Location = new System.Drawing.Point(16, 29);
            this.siteALog.Multiline = true;
            this.siteALog.Name = "siteALog";
            this.siteALog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.siteALog.Size = new System.Drawing.Size(805, 228);
            this.siteALog.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.siteALog);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 274);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Site A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.siteBLog);
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(839, 274);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Site B";
            // 
            // siteBLog
            // 
            this.siteBLog.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteBLog.Location = new System.Drawing.Point(16, 29);
            this.siteBLog.Multiline = true;
            this.siteBLog.Name = "siteBLog";
            this.siteBLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.siteBLog.Size = new System.Drawing.Size(805, 228);
            this.siteBLog.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(327, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Compare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // warningLbl1
            // 
            this.warningLbl1.AutoSize = true;
            this.warningLbl1.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLbl1.Location = new System.Drawing.Point(12, 609);
            this.warningLbl1.Name = "warningLbl1";
            this.warningLbl1.Size = new System.Drawing.Size(46, 17);
            this.warningLbl1.TabIndex = 7;
            this.warningLbl1.Text = "Status";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSiteATimeTaken);
            this.groupBox3.Controls.Add(this.lblSiteABytesReceived);
            this.groupBox3.Controls.Add(this.lblSiteABytesSent);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(28, 667);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 120);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Site A";
            // 
            // lblSiteABytesSent
            // 
            this.lblSiteABytesSent.AutoSize = true;
            this.lblSiteABytesSent.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiteABytesSent.Location = new System.Drawing.Point(16, 31);
            this.lblSiteABytesSent.Name = "lblSiteABytesSent";
            this.lblSiteABytesSent.Size = new System.Drawing.Size(70, 17);
            this.lblSiteABytesSent.TabIndex = 8;
            this.lblSiteABytesSent.Text = "Bytes sent:";
            // 
            // lblSiteABytesReceived
            // 
            this.lblSiteABytesReceived.AutoSize = true;
            this.lblSiteABytesReceived.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiteABytesReceived.Location = new System.Drawing.Point(16, 58);
            this.lblSiteABytesReceived.Name = "lblSiteABytesReceived";
            this.lblSiteABytesReceived.Size = new System.Drawing.Size(94, 17);
            this.lblSiteABytesReceived.TabIndex = 9;
            this.lblSiteABytesReceived.Text = "Bytes recevied:";
            // 
            // lblSiteATimeTaken
            // 
            this.lblSiteATimeTaken.AutoSize = true;
            this.lblSiteATimeTaken.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiteATimeTaken.Location = new System.Drawing.Point(16, 85);
            this.lblSiteATimeTaken.Name = "lblSiteATimeTaken";
            this.lblSiteATimeTaken.Size = new System.Drawing.Size(75, 17);
            this.lblSiteATimeTaken.TabIndex = 10;
            this.lblSiteATimeTaken.Text = "Time taken:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblSiteBTimeTaken);
            this.groupBox4.Controls.Add(this.lblSiteBBytesReceived);
            this.groupBox4.Controls.Add(this.lblSiteBBytesSent);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(596, 667);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 120);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Site B";
            // 
            // lblSiteBTimeTaken
            // 
            this.lblSiteBTimeTaken.AutoSize = true;
            this.lblSiteBTimeTaken.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiteBTimeTaken.Location = new System.Drawing.Point(16, 85);
            this.lblSiteBTimeTaken.Name = "lblSiteBTimeTaken";
            this.lblSiteBTimeTaken.Size = new System.Drawing.Size(75, 17);
            this.lblSiteBTimeTaken.TabIndex = 10;
            this.lblSiteBTimeTaken.Text = "Time taken:";
            // 
            // lblSiteBBytesReceived
            // 
            this.lblSiteBBytesReceived.AutoSize = true;
            this.lblSiteBBytesReceived.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiteBBytesReceived.Location = new System.Drawing.Point(16, 58);
            this.lblSiteBBytesReceived.Name = "lblSiteBBytesReceived";
            this.lblSiteBBytesReceived.Size = new System.Drawing.Size(94, 17);
            this.lblSiteBBytesReceived.TabIndex = 9;
            this.lblSiteBBytesReceived.Text = "Bytes recevied:";
            // 
            // lblSiteBBytesSent
            // 
            this.lblSiteBBytesSent.AutoSize = true;
            this.lblSiteBBytesSent.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiteBBytesSent.Location = new System.Drawing.Point(16, 31);
            this.lblSiteBBytesSent.Name = "lblSiteBBytesSent";
            this.lblSiteBBytesSent.Size = new System.Drawing.Size(70, 17);
            this.lblSiteBBytesSent.TabIndex = 8;
            this.lblSiteBBytesSent.Text = "Bytes sent:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblResultWinner);
            this.groupBox5.Controls.Add(this.lblResultTimeTaken);
            this.groupBox5.Controls.Add(this.lblResultBytesReceived);
            this.groupBox5.Controls.Add(this.lblResultBytesSent);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(315, 667);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(237, 155);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Compare result";
            // 
            // lblResultTimeTaken
            // 
            this.lblResultTimeTaken.AutoSize = true;
            this.lblResultTimeTaken.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultTimeTaken.Location = new System.Drawing.Point(16, 110);
            this.lblResultTimeTaken.Name = "lblResultTimeTaken";
            this.lblResultTimeTaken.Size = new System.Drawing.Size(75, 17);
            this.lblResultTimeTaken.TabIndex = 10;
            this.lblResultTimeTaken.Text = "Time taken:";
            // 
            // lblResultBytesReceived
            // 
            this.lblResultBytesReceived.AutoSize = true;
            this.lblResultBytesReceived.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultBytesReceived.Location = new System.Drawing.Point(16, 83);
            this.lblResultBytesReceived.Name = "lblResultBytesReceived";
            this.lblResultBytesReceived.Size = new System.Drawing.Size(94, 17);
            this.lblResultBytesReceived.TabIndex = 9;
            this.lblResultBytesReceived.Text = "Bytes recevied:";
            // 
            // lblResultBytesSent
            // 
            this.lblResultBytesSent.AutoSize = true;
            this.lblResultBytesSent.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultBytesSent.Location = new System.Drawing.Point(16, 56);
            this.lblResultBytesSent.Name = "lblResultBytesSent";
            this.lblResultBytesSent.Size = new System.Drawing.Size(70, 17);
            this.lblResultBytesSent.TabIndex = 8;
            this.lblResultBytesSent.Text = "Bytes sent:";
            // 
            // lblResultWinner
            // 
            this.lblResultWinner.AutoSize = true;
            this.lblResultWinner.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultWinner.Location = new System.Drawing.Point(16, 30);
            this.lblResultWinner.Name = "lblResultWinner";
            this.lblResultWinner.Size = new System.Drawing.Size(53, 17);
            this.lblResultWinner.TabIndex = 11;
            this.lblResultWinner.Text = "Winner:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 867);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.warningLbl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox siteALog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox siteBLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label warningLbl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSiteATimeTaken;
        private System.Windows.Forms.Label lblSiteABytesReceived;
        private System.Windows.Forms.Label lblSiteABytesSent;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblSiteBTimeTaken;
        private System.Windows.Forms.Label lblSiteBBytesReceived;
        private System.Windows.Forms.Label lblSiteBBytesSent;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblResultWinner;
        private System.Windows.Forms.Label lblResultTimeTaken;
        private System.Windows.Forms.Label lblResultBytesReceived;
        private System.Windows.Forms.Label lblResultBytesSent;
    }
}

